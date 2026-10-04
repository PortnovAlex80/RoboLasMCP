using System;
using System.Collections.Generic;

namespace System.Windows.Forms
{
    public enum DialogResult { Yes, No, Cancel, OK }
    public enum MessageBoxButtons { OK, YesNo, YesNoCancel }
    public enum MessageBoxIcon { Warning, Information, Error, Question }
    public static class MessageBox
    {
        public static DialogResult Show(string text, string title,
            MessageBoxButtons buttons, MessageBoxIcon icon)
        { return LAS_TERRAIN.Tests.PlanDrawFixture.NextDecision(); }
    }
    public sealed class OpenFileDialog : IDisposable
    {
        public static string NextFile;
        public static string[] NextFiles;
        public static Action OnShow;
        public string Title, Filter, InitialDirectory;
        public bool CheckFileExists;
        public bool Multiselect;
        public string FileName;
        public string[] FileNames;
        public DialogResult ShowDialog()
        {
            if (OnShow != null) OnShow();
            FileName = NextFile;
            FileNames = NextFiles ?? (NextFile == null ? new string[0] : new[] { NextFile });
            NextFiles = null;
            NextFile = null;
            return FileNames.Length == 0 ? DialogResult.Cancel : DialogResult.OK;
        }
        public void Dispose() { }
    }
    public sealed class FolderBrowserDialog : IDisposable
    {
        public static string NextFolder;
        public static Action OnShow;
        public string Description, SelectedPath;
        public DialogResult ShowDialog()
        {
            if (OnShow != null) OnShow();
            if (NextFolder == null) return DialogResult.Cancel;
            SelectedPath = NextFolder; NextFolder = null;
            return DialogResult.OK;
        }
        public void Dispose() { }
    }
}

namespace Topomatic.Cad.Foundation
{
    public struct BoundingBox2D
    {
        public Vector2D Min, Max;
        public BoundingBox2D(Vector2D min, Vector2D max) { Min = min; Max = max; }
    }
    public struct Vector2D
    {
        public double X, Y;
        public Vector2D(double x, double y) { X = x; Y = y; }
    }
    public struct Vector3D
    {
        public double X, Y, Z;
        public Vector2D Pos { get { return new Vector2D(X, Y); } }
        public Vector3D(double x, double y, double z) { X = x; Y = y; Z = z; }
    }
}

namespace Topomatic.Cad.View
{
    using Topomatic.Cad.Foundation;
    public enum ArrayMode { Point }
    public delegate void DrawCursorEvent(CadPen pen, Vector3D vertex);
    public sealed class CadPen
    {
        public System.Drawing.Color Color;
        public float Width;
        public void BeginDraw() { }
        public void EndDraw() { }
        public void BeginArray() { }
        public void EndArray(ArrayMode mode) { }
        public void Vertex(Vector2D point) { }
        public void DrawLine(Vector2D first, Vector2D second) { }
    }
    public sealed class CadView
    {
        private readonly Dictionary<Guid, object> _layers = new Dictionary<Guid, object>();
        public bool IsDisposed;
        public bool IsHandleCreated = true;
        public event DrawCursorEvent DynamicDraw;
        public int HandlerCount { get { return DynamicDraw == null ? 0 : DynamicDraw.GetInvocationList().Length; } }
        public object this[Guid id]
        { get { object result; return _layers.TryGetValue(id, out result) ? result : null; } }
        public int Invalidations;
        public void AddLayer(CadViewLayer layer)
        { _layers[layer.LayerGuid] = layer; layer.CadView = this; }
        public void Unlock() { }
        public void Invalidate() { Invalidations++; }
    }
    public abstract class SelectionSet { }
    public sealed class ObjectSnapEventArgs : EventArgs { }
    public abstract class CadViewLayer
    {
        public CadView CadView;
        public abstract Guid LayerGuid { get; }
        public abstract string Name { get; }
        public abstract SelectionSet SelectionSet { get; }
        protected abstract void OnPaint(CadPen pen);
        protected abstract bool OnGetLimits(out BoundingBox2D lim);
        protected abstract void OnGetSnapObjects(ObjectSnapEventArgs e);
        public void Paint(CadPen pen) { OnPaint(pen); }
    }
}

namespace Topomatic.Cad.View.Design { }

namespace Topomatic.Cad.View.Hints
{
    using Topomatic.Cad.Foundation;
    using Topomatic.Cad.View;
    public static class CadCursors
    {
        public static bool GetPoint(CadView view, out Vector3D point, string prompt)
        { return LAS_TERRAIN.Tests.PlanDrawFixture.NextPoint(out point); }
    }
}

namespace Topomatic.Alg
{
    public sealed class TestSection { public uint Id; public double Station; }
    public sealed class TestCorridor
    { public List<TestSection> Sections = new List<TestSection>(); }
    public sealed class Alignment { public TestCorridor Corridor = new TestCorridor(); }
}

namespace Topomatic.FoundationClasses
{
    public sealed class URI
    {
        private readonly Uri _value;
        public URI(string text) { _value = new Uri(text, UriKind.RelativeOrAbsolute); }
        public bool IsAbsoluteUri { get { return _value.IsAbsoluteUri; } }
        public string AsAbsoluteUri { get { return _value.AbsoluteUri; } }
        public string AsFilePath { get { return _value.LocalPath; } }
    }
}

namespace Topomatic.Alg.Runtime.ServiceClasses
{
    public sealed class TestSectionManager { public int CurrentSection; }
    public sealed class ActiveAlignmentReciver<T> : IDisposable
    {
        public T Alignment;
        public static readonly TestSectionManager CurrentManager = new TestSectionManager();
        public TestSectionManager Manager { get { return CurrentManager; } }
        public static ActiveAlignmentReciver<T> CreateReciver(bool unused)
        {
            return new ActiveAlignmentReciver<T> {
                Alignment = (T)(object)LAS_TERRAIN.Tests.PlanDrawFixture.ActiveAlignment };
        }
        public void Dispose() { }
    }
}

namespace Topomatic.ApplicationPlatform
{
    public sealed class Project
    {
        public string Alias;
        public Topomatic.FoundationClasses.URI TargetProjectUri;
    }
    public sealed class Model { public Project Project; public object Uri; }
    public sealed class ApplicationHost
    {
        public static ApplicationHost Current;
        public Project ActiveProject;
        public object ActiveDocument;
    }
}
namespace Topomatic.ApplicationPlatform.Plugins { }

namespace Topomatic.Lidar
{
    public sealed class PointArray
    {
        public Topomatic.Cad.Foundation.Vector3D[] Values =
            new Topomatic.Cad.Foundation.Vector3D[0];
        public int Count { get { return Values.Length; } }
        public Topomatic.Cad.Foundation.Vector3D[] GetBuffer() { return Values; }
    }
    public sealed class WeightArray
    {
        public byte[] Values = new byte[0];
        public int Count { get { return Values.Length; } }
        public byte[] GetBuffer() { return Values; }
    }
    public sealed class QuadTreeIndexer
    {
        public PointArray points;
        public WeightArray weights;
        public Topomatic.Cad.Foundation.Vector3D scale;
        public Topomatic.Cad.Foundation.Vector3D position;
    }
    public sealed class LidarBuffer
    {
        public string fullpath;
        public List<QuadTreeIndexer> indexers = new List<QuadTreeIndexer>();
    }
}

namespace Topomatic.Controls { }
namespace Topomatic.Controls.Dialogs
{
    public static class MessageDlg
    {
        public static readonly List<string> Messages = new List<string>();
        public static void Show(string text)
        {
            Messages.Add(text);
            if (LAS_TERRAIN.Tests.PlanDrawFixture.OnMessage != null)
                LAS_TERRAIN.Tests.PlanDrawFixture.OnMessage(text);
        }
        public static void Show(string text, System.Windows.Forms.MessageBoxButtons buttons,
            System.Windows.Forms.MessageBoxIcon icon) { Show(text); }
    }
}

namespace LAS_TERRAIN
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class SectionCmdAttribute : Attribute
    { public SectionCmdAttribute(string name) { } }
    public interface ISectionUseCase
    { string Name { get; } void Run(SectionEnv env); }
    public sealed class SectionEnv
    {
        public Topomatic.Cad.View.CadView CadView;
        public SectionEnv(Topomatic.Cad.View.CadView view) { CadView = view; }
    }
}

namespace LAS_TERRAIN.Infrastructure
{
    using Topomatic.Alg;
    using Topomatic.ApplicationPlatform;
    using Topomatic.Cad.View;
    public static class UserDialogs
    {
        public static bool IsCadViewValid(CadView view) { return view != null; }
    }
    public static class PluginCoreOps
    {
        public static Model FindModel(Alignment alignment)
        { return LAS_TERRAIN.Tests.PlanDrawFixture.Model; }
    }
    public static class AlignmentValueConverter
    {
        public static Guid GetId(Alignment alignment)
        { return LAS_TERRAIN.Tests.PlanDrawFixture.AlignmentId; }
    }
}

namespace LAS_TERRAIN.Service
{
    using Topomatic.Alg;
    using Topomatic.Lidar;
    public static class LidarBufferService
    {
        public static List<LidarBuffer> CollectBuffers(Alignment alignment)
        { return LAS_TERRAIN.Tests.PlanDrawFixture.Buffers; }
    }
}

namespace LAS_TERRAIN.Visualization
{
    using Topomatic.Cad.View;
    public sealed class CrsOverlaySelectionSet : SelectionSet
    {
        public CrsOverlaySelectionSet(object owner) { }
    }
}
