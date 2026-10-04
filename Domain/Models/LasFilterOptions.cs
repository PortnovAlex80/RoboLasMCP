// Models/LasFilterOptions.cs
using System;

namespace LAS_TERRAIN.Models
{
    /// <summary>
    /// Опции фильтрации: асинхронность, смещения и ширина коридора.
    ///
    /// СЕМАНТИКА BORDER:
    /// - Пользователь вводит "толщину" (полная ширина слайса)
    /// - Внутри используется HalfBorder (полу-толщина для проверки ±dist)
    /// - FromThickness(thickness) автоматически преобразует толщину → полу-толщину
    /// </summary>
    public class LasFilterOptions
    {
        /// <summary>Асинхронный режим (Parallel.ForEach) или нет</summary>
        public bool Async;

        /// <summary>Смещение от центра влево (null → DtmSizeLeft)</summary>
        public double? CentralLeftOffset;

        /// <summary>Смещение от центра вправо (null → DtmSizeRight)</summary>
        public double? CentralRightOffset;

        /// <summary>
        /// Полу-толщина слайса (внутреннее использование).
        /// Проверка: Math.Abs(distance) &lt; HalfBorder
        /// Результат: слайс шириной 2 * HalfBorder
        /// </summary>
        public double HalfBorder;

        /// <summary>
        /// Split export owns the positive slice border and excludes the negative
        /// border. Other collectors keep the historical open-border behavior.
        /// </summary>
        public bool IncludePositiveSliceBorder;

        // The public fields remain for existing callers. Calculations use a
        // private copy so callbacks cannot change slice geometry mid-run.
        internal LasFilterOptions Copy()
        {
            return new LasFilterOptions(Async, HalfBorder,
                CentralLeftOffset, CentralRightOffset)
            {
                IncludePositiveSliceBorder = IncludePositiveSliceBorder
            };
        }

        public bool ContainsSliceDistance(double distance)
        {
            return distance > -HalfBorder &&
                (distance < HalfBorder ||
                    (IncludePositiveSliceBorder && distance == HalfBorder));
        }

        /// <summary>
        /// Устаревшее имя для совместимости. Используйте HalfBorder или FromThickness().
        /// </summary>
        [Obsolete("Use HalfBorder property or FromThickness() factory method")]
        public double Border
        {
            get => HalfBorder;
            set => HalfBorder = value;
        }

        /// <summary>
        /// Создаёт опции из ПОЛЬЗОВАТЕЛЬСКОЙ толщины (полная ширина слайса).
        /// Автоматически преобразует в полу-толщину для внутреннего использования.
        /// </summary>
        /// <param name="thickness">Полная толщина слайса (пользовательский ввод)</param>
        /// <param name="async">Асинхронный режим</param>
        /// <param name="centralLeftOffset">Смещение влево (null → DtmSizeLeft)</param>
        /// <param name="centralRightOffset">Смещение вправо (null → DtmSizeRight)</param>
        public static LasFilterOptions FromThickness(
            double thickness,
            bool async = true,
            double? centralLeftOffset = null,
            double? centralRightOffset = null)
        {
            return new LasFilterOptions
            {
                Async = async,
                HalfBorder = thickness / 2.0,
                CentralLeftOffset = centralLeftOffset,
                CentralRightOffset = centralRightOffset
            };
        }

        /// <summary>
        /// Конструктор для внутреннего использования (полу-толщина).
        /// Пользовательский код должен использовать FromThickness().
        /// </summary>
        /// <param name="async">Асинхронный режим</param>
        /// <param name="halfBorder">Полу-толщина (внутренний параметр)</param>
        /// <param name="centralLeftOffset">Смещение влево</param>
        /// <param name="centralRightOffset">Смещение вправо</param>
        public LasFilterOptions(
            bool async = true,
            double halfBorder = 0.125,
            double? centralLeftOffset = null,
            double? centralRightOffset = null)
        {
            Async = async;
            HalfBorder = halfBorder;
            CentralLeftOffset = centralLeftOffset;
            CentralRightOffset = centralRightOffset;
        }
    }
}
