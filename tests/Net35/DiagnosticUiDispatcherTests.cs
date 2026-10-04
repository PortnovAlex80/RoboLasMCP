using System;
using LAS_TERRAIN.Infrastructure;
using LAS_TERRAIN.Testing.Remoting;

namespace Topomatic.ApplicationPlatform
{
    public interface IMainForm
    {
        bool IsHandleCreated { get; }
        bool InvokeRequired { get; }
        object Invoke(Delegate method);
    }

    public interface IApplicationHost
    {
        IMainForm MainForm { get; }
    }

    public static class ApplicationHost
    {
        public static IApplicationHost Current;
    }
}

namespace LAS_TERRAIN.Tests
{
    using Topomatic.ApplicationPlatform;

    internal sealed class FakeMainForm : IMainForm
    {
        internal bool HandleCreated = true;
        internal bool RequiresInvoke = true;
        internal bool InsideInvoke;
        internal bool CloseBeforeInvoke;
        internal bool FailBeforeInvoke;
        internal int Invocations;

        public bool IsHandleCreated { get { return HandleCreated; } }
        public bool InvokeRequired { get { return RequiresInvoke; } }
        public object Invoke(Delegate method)
        {
            Invocations++;
            if (CloseBeforeInvoke) throw new ObjectDisposedException("main form");
            if (FailBeforeInvoke) throw new InvalidOperationException("handle lost");
            InsideInvoke = true;
            try { return ((Func<int>)method)(); }
            finally { InsideInvoke = false; }
        }
    }

    internal sealed class FakeHost : IApplicationHost
    {
        internal IMainForm Form;
        internal bool FailOnGet;
        public IMainForm MainForm
        {
            get
            {
                if (FailOnGet) throw new ObjectDisposedException("host main form");
                return Form;
            }
        }
    }

    internal static class DiagnosticUiDispatcherTests
    {
        private static int checks;

        private static void Check(bool condition, string message)
        {
            checks++;
            if (!condition) throw new Exception(message);
        }

        public static int Main()
        {
            FakeMainForm form = new FakeMainForm();
            ApplicationHost.Current = new FakeHost { Form = form };
            int value = DiagnosticUiDispatcher.Invoke(delegate
            {
                Check(form.InsideInvoke, "model callback ran outside UI dispatch");
                Check(PluginOperationGate.TryEnter() == null,
                    "callback did not hold the command gate");
                return 42;
            }, -1, -2);
            Check(value == 42 && form.Invocations == 1,
                "dispatched result changed");

            form.RequiresInvoke = false;
            value = DiagnosticUiDispatcher.Invoke(delegate
            {
                Check(!form.InsideInvoke, "same-thread callback was invoked again");
                return 7;
            }, -1, -2);
            Check(value == 7 && form.Invocations == 1, "same-thread path changed");
            form.RequiresInvoke = true;

            using (PluginOperationGate.Lease held = PluginOperationGate.TryEnter())
            {
                int before = form.Invocations;
                value = DiagnosticUiDispatcher.Invoke(delegate { throw new Exception("must not run"); }, -1, -2);
                Check(value == -1 && form.Invocations == before,
                    "busy IPC touched the UI dispatcher");
            }

            form.HandleCreated = false;
            value = DiagnosticUiDispatcher.Invoke(delegate { throw new Exception("must not run"); }, -1, -2);
            Check(value == -2, "uncreated form was used");
            form.HandleCreated = true;

            form.CloseBeforeInvoke = true;
            value = DiagnosticUiDispatcher.Invoke(delegate { throw new Exception("must not run"); }, -1, -2);
            Check(value == -2, "closed form did not return unavailable");
            form.CloseBeforeInvoke = false;
            form.FailBeforeInvoke = true;
            value = DiagnosticUiDispatcher.Invoke(delegate { throw new Exception("must not run"); }, -1, -2);
            Check(value == -2, "lost form handle did not return unavailable");
            form.FailBeforeInvoke = false;

            bool propagated = false;
            try
            {
                DiagnosticUiDispatcher.Invoke<int>(delegate
                { throw new InvalidOperationException("callback failed"); }, -1, -2);
            }
            catch (InvalidOperationException) { propagated = true; }
            Check(propagated, "callback failure was disguised as unavailable");
            propagated = false;
            try
            {
                DiagnosticUiDispatcher.Invoke<int>(delegate
                { throw new ObjectDisposedException("callback target"); }, -1, -2);
            }
            catch (ObjectDisposedException) { propagated = true; }
            Check(propagated, "disposed callback target was disguised as unavailable");
            value = DiagnosticUiDispatcher.Invoke(delegate { return 9; }, -1, -2);
            Check(value == 9, "gate did not release after callback failure");

            ApplicationHost.Current = new FakeHost { FailOnGet = true };
            value = DiagnosticUiDispatcher.Invoke(delegate { throw new Exception("must not run"); }, -1, -2);
            Check(value == -2, "disposed host main form was used");

            ApplicationHost.Current = null;
            value = DiagnosticUiDispatcher.Invoke(delegate { throw new Exception("must not run"); }, -1, -2);
            Check(value == -2, "missing host did not return unavailable");

            Console.WriteLine("Diagnostic UI dispatcher: " + checks + " checks passed.");
            return 0;
        }
    }
}
