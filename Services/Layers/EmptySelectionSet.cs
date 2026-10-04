// Visualization/CrsOverlaySelectionSet.cs
using System;
using System.Collections;
using System.Collections.Generic;
using Topomatic.Cad.Foundation;
using Topomatic.Cad.View;
using Topomatic.Cad.View.Hints;

namespace LAS_TERRAIN.Visualization
{
    internal sealed class CrsOverlaySelectionSet : SelectionSet
    {
        private readonly CadViewLayer _layer;

        public CrsOverlaySelectionSet(PlanOverlayLayer layer) : base(layer)
        {
            _layer = layer;
        }

        // Ничего не поддерживаем
        public override bool SupportTransform => false;
        public override bool SupportClipboard => false;
        public override bool SupportCopyTransform => false;
        public override bool SupportDragAndDrop => false;

        // Пустота
        public override int Count => 0;
        public override void Clear() { }
        public override void Erase() { }

        public override IEnumerator GetEnumerator()
        {
            yield break;
        }

        public override IEnumerable<KeyValuePair<double, object>> GetObjectsAtPoint(
            Vector3D point, Predicate<object> match, int waitTimeOut)
        {
            yield break;
        }

        public override void GetObjectsByFrame(
            FrameSelectType mode, RectangleD rect, Predicate<object> match, Action<object> action)
        {
            // noop
        }

        public override void GetObjectsByPolygon(
            FrameSelectType mode, List<Vector2D> pointsList, Predicate<object> match, Action<object> action)
        {
            // noop
        }

        public override IEnumerable GetSelectable()
        {
            yield break;
        }

        public override bool IsEnable(object obj) => _layer?.Enable ?? false;
        public override bool IsOwned(object obj) => false;
        public override bool IsSelected(object obj) => false;

        public override void Select(object item, bool bFlag) { }

        // На всякий случай глушим мягкие виртуалки
        public override void FilterSelected(Predicate<object> match) { }
        public override void Select(IEnumerable pSelSet, bool bFlag) { }

        public override object GetTransformData() => null;
        public override void Transform(object data, Matrix transform, bool copy) { }
        public override void Move(object data, double x, double y, double z, bool copy) { }
        public override void Rotate(object data, Vector2D basePoint, double rotationAngle, bool copy) { }
        public override void Scale(object data, Vector2D basePoint, double scaleFactorX, double scaleFactorY, bool copy) { }
        public override void Mirror(object data, Vector2D a, Vector2D b, bool copy) { }
        public override void PaintTransformData(object data, CadPen pen) { }

        public override bool DragOver(string path) => false;
        public override bool DragDrop(string path) => false;
    }
}
