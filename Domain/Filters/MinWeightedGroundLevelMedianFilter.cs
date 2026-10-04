using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Topomatic.Cad.Foundation;

namespace LAS_TERRAIN.Filters
{
    internal class MinWeightedGroundLevelMedianFilter
    {
        public static List<Vector2D> Apply(List<Vector2D> points)
        {
            if (points.Count == 0) return new List<Vector2D>();

            points = MorphologicalFilter(points, 13); // 15 - оптимально. не режет насыпи. если больше, то режем насыпи, меньше - прыгает на . Чуть сннизил до 12

            // Найти индекс минимальной точки по Y
            // int minPointIndex = points.FindIndex(p => p.Y == points.Min(min => min.Y));
            int minPointIndex = 0;
            double minY = points[0].Y;
            for (int i = 1; i < points.Count; i++)
            {
                if (points[i].Y < minY)
                {
                    minY = points[i].Y;
                    minPointIndex = i;
                }
            }

            // Разделить на два списка и инвертировать порядок точек в левом списке
            var leftPoints = points.Take(minPointIndex + 1).Reverse().ToList();
            var rightPoints = points.Skip(minPointIndex).ToList();

            // Обработать каждый список
            var filteredLeftPoints = FilterPoints(leftPoints);
            var filteredRightPoints = FilterPoints(rightPoints);

            // Инвертировать порядок обработанных левых точек и объединить списки
            filteredLeftPoints.Reverse();
            filteredLeftPoints.AddRange(filteredRightPoints.Skip(1));
            return (TriangleBaseDistanceFilter(filteredLeftPoints)); // del inperpolation and triangulate
        }

        private static List<Vector2D> FilterPoints(List<Vector2D> points)
        {
            List<Vector2D> filteredPoints = new List<Vector2D>();
            double threshold = 1.00;
            int i = 0;

            while (i < points.Count)
            {
                int windowSize = 4;
                List<Vector2D> windowPoints = points.Skip(i).Take(windowSize).ToList();
                Vector2D basePoint = windowPoints.Aggregate((lowest, point) => point.Y < lowest.Y ? point : lowest);
                List<Vector2D> weightedPoints = windowPoints.Where(point => Math.Abs(point.Y - basePoint.Y) <= threshold).ToList();

                double weightedMedianX = GetWeightedMedian(weightedPoints.Select(p => p.X).ToList(), basePoint, weightedPoints);
                double weightedMedianY = GetWeightedMedian(weightedPoints.Select(p => p.Y).ToList(), basePoint, weightedPoints);

                filteredPoints.Add(new Vector2D { X = weightedMedianX, Y = weightedMedianY });

                //i += (int)(windowSize * 2.0 / 4.0); // 
                // i += windowSize; // 
                i++;
            }

            return filteredPoints;
        }

        private static double GetWeightedMedian(List<double> values, Vector2D basePoint, List<Vector2D> weightedPoints)
        {
            // Выберите подходящее значение для lambda
            double lambda = 1;

            List<ValueWeightPair> weightedValues = values.Select((value, index) => new ValueWeightPair
            {
                Value = value,
                Weight = Math.Exp(-lambda * Math.Abs(weightedPoints[index].Y - basePoint.Y))
            }).ToList();

            weightedValues.Sort((a, b) => a.Value.CompareTo(b.Value));

            double totalWeight = weightedValues.Sum(pair => pair.Weight);
            double accumulatedWeight = 0;

            foreach (ValueWeightPair pair in weightedValues)
            {
                accumulatedWeight += pair.Weight;
                if (accumulatedWeight >= totalWeight / 2)
                {
                    return pair.Value;
                }
            }

            return weightedValues[weightedValues.Count / 2].Value;
        }

        private class ValueWeightPair
        {
            public double Value { get; set; }
            public double Weight { get; set; }
        }


        private static List<Vector2D> MorphologicalFilter(List<Vector2D> points, int kernelSize)
        {
            // Эрозия: минимальная точка в окне
            List<Vector2D> erodedPoints = Erode(points, kernelSize);

            // Дилатация: максимальная точка в окне
            List<Vector2D> dilatedPoints = Dilate(erodedPoints, kernelSize);

            return dilatedPoints;
        }

        private static List<Vector2D> Erode(List<Vector2D> points, int kernelSize)
        {
            List<Vector2D> erodedPoints = new List<Vector2D>();

            for (int i = 0; i < points.Count; i++)
            {
                Vector2D minPoint = points.Skip(Math.Max(i - kernelSize / 2, 0))
                                          .Take(kernelSize)
                                          .OrderBy(p => p.Y)
                                          .FirstOrDefault();

                erodedPoints.Add(minPoint);
            }

            return erodedPoints;
        }

        private static List<Vector2D> Dilate(List<Vector2D> points, int kernelSize)
        {
            List<Vector2D> dilatedPoints = new List<Vector2D>();

            for (int i = 0; i < points.Count; i++)
            {
                Vector2D maxPoint = points.Skip(Math.Max(i - kernelSize / 2, 0))
                                          .Take(kernelSize)
                                          .OrderByDescending(p => p.Y)
                                          .FirstOrDefault();

                dilatedPoints.Add(maxPoint);
            }

            return dilatedPoints;
        }

        private static List<Vector2D> InterpolatePoints(List<Vector2D> points, double step)
        {
            List<Vector2D> interpolatedPoints = new List<Vector2D>();

            // Предполагаем, что точки уже отсортированы по X
            for (double x = points.First().X; x <= points.Last().X; x += step)
            {
                // Находим две ближайшие точки
                Vector2D point1 = points.Last(p => p.X <= x);
                Vector2D point2 = points.First(p => p.X >= x);

                if (point1.X == point2.X)
                {
                    interpolatedPoints.Add(new Vector2D { X = x, Y = point1.Y });
                }
                else
                {
                    // Выполняем линейную интерполяцию
                    double y = point1.Y + (x - point1.X) * (point2.Y - point1.Y) / (point2.X - point1.X);
                    interpolatedPoints.Add(new Vector2D { X = x, Y = y });
                }
            }

            return interpolatedPoints;
        }

        private static List<Vector2D> TriangleBaseDistanceFilter(List<Vector2D> points)
        {
            return TriangleBaseDistanceFilter(points, 0.15);
        }

        private static List<Vector2D> TriangleBaseDistanceFilter(List<Vector2D> points, double epsilon)
        {
            List<Vector2D> filteredPoints = new List<Vector2D>();

            if (points.Count < 3)
            {
                return points; // Недостаточно точек для формирования треугольника
            }

            filteredPoints.Add(points[0]); // Первая точка всегда добавляется

            for (int i = 1; i < points.Count - 1; i++)
            {
                Vector2D p1 = points[i - 1];
                Vector2D p2 = points[i];
                Vector2D p3 = points[i + 1];

                // Длина базы (евклидово расстояние p1-p3)
                double dx = p3.X - p1.X;
                double dy = p3.Y - p1.Y;
                double baseLength = Math.Sqrt(dx * dx + dy * dy);

                // Перпендикулярное расстояние от p2 до линии p1-p3
                // Работает корректно и на площадке, и на откосе
                // Формула: |cross(p3-p1, p2-p1)| / |p3-p1|
                double crossProduct = dx * (p2.Y - p1.Y) - dy * (p2.X - p1.X);
                double perpHeight = baseLength > 0 ? Math.Abs(crossProduct) / baseLength : 0;

                // Удаляем рельсы: узкая база + высокий пик
                bool isRailSpike = baseLength <= 0.20 && perpHeight > epsilon;

                if (!isRailSpike)
                {
                    filteredPoints.Add(p2);
                }
            }

            filteredPoints.Add(points[points.Count - 1]); // Последняя точка всегда добавляется

            return filteredPoints;
        }

    }

}



