using System;
using System.Diagnostics;
using System.Threading;
using LAS_TERRAIN.Infrastructure;

namespace Topomatic.Cad.View
{
    public sealed class CadView { }
}

namespace Topomatic.Controls.Dialogs
{
    public static class MessageDlg
    {
        public static int Calls;
        public static void Show(string message, System.Windows.Forms.MessageBoxButtons buttons,
            System.Windows.Forms.MessageBoxIcon icon) { Calls++; }
    }
}

namespace LAS_TERRAIN
{
    internal sealed class SectionEnv
    {
        internal SectionEnv(Topomatic.Cad.View.CadView view) { }
    }

    internal interface ISectionUseCase
    {
        void Run(SectionEnv env);
    }

    internal delegate void TestAction();

    internal sealed class FakeUseCase : ISectionUseCase
    {
        internal TestAction Action;
        public void Run(SectionEnv env) { Action(); }
    }

    internal static class SectionRegistry
    {
        internal static readonly FakeUseCase Command = new FakeUseCase();
        internal static ISectionUseCase Resolve(string name)
        { return name == "known" ? Command : null; }
    }
}

namespace LAS_TERRAIN.Tests
{
    internal static class PluginOperationGateTests
    {
        private static int checks;

        private static void Check(bool condition, string message)
        {
            checks++;
            if (!condition) throw new Exception(message);
        }

        private static void ConcurrentAndNestedEntries()
        {
            using (ManualResetEvent entered = new ManualResetEvent(false))
            using (ManualResetEvent release = new ManualResetEvent(false))
            {
                int calls = 0;
                Exception workerError = null;
                SectionRegistry.Command.Action = delegate
                {
                    Interlocked.Increment(ref calls);
                    entered.Set();
                    if (!release.WaitOne(5000, false))
                        throw new Exception("held command timed out");
                };
                Thread worker = new Thread(delegate()
                {
                    try { SectionCommandRunner.Run("known", null); }
                    catch (Exception error) { workerError = error; }
                });
                worker.Start();
                try
                {
                    Check(entered.WaitOne(5000, false), "first command did not enter");
                    Stopwatch timer = Stopwatch.StartNew();
                    SectionCommandRunner.Run("known", null);
                    timer.Stop();
                    Check(timer.ElapsedMilliseconds < 1000, "second command waited on active command");
                    Check(calls == 1, "concurrent command entered the active operation");
                }
                finally
                {
                    release.Set();
                    Check(worker.Join(5000), "first command did not finish");
                }
                Check(workerError == null, "first command failed");
            }

            int nestedCalls = 0;
            SectionRegistry.Command.Action = delegate
            {
                nestedCalls++;
                SectionCommandRunner.Run("known", null);
            };
            SectionCommandRunner.Run("known", null);
            Check(nestedCalls == 1, "nested command entered the active operation");
        }

        private static void ReleaseOnFailureAndIdempotentDispose()
        {
            SectionRegistry.Command.Action = delegate { throw new OperationCanceledException(); };
            bool cancelled = false;
            try { SectionCommandRunner.Run("known", null); }
            catch (OperationCanceledException) { cancelled = true; }
            Check(cancelled, "command cancellation did not propagate");

            int calls = 0;
            SectionRegistry.Command.Action = delegate { calls++; };
            SectionCommandRunner.Run("known", null);
            Check(calls == 1, "gate remained busy after cancellation");

            SectionCommandRunner.Run("missing", null);
            Check(Topomatic.Controls.Dialogs.MessageDlg.Calls == 1,
                "unknown command warning changed");
            SectionCommandRunner.Run("known", null);
            Check(calls == 2, "gate remained busy after unknown command");

            PluginOperationGate.Lease first = PluginOperationGate.TryEnter();
            Check(first != null, "first direct lease denied");
            first.Dispose();
            PluginOperationGate.Lease second = PluginOperationGate.TryEnter();
            Check(second != null, "second direct lease denied");
            first.Dispose();
            Check(PluginOperationGate.TryEnter() == null,
                "double dispose released a later operation");
            second.Dispose();
            PluginOperationGate.Lease third = PluginOperationGate.TryEnter();
            Check(third != null,
                "later lease did not release the gate");
            third.Dispose();
        }

        public static int Main()
        {
            ConcurrentAndNestedEntries();
            ReleaseOnFailureAndIdempotentDispose();
            Console.WriteLine("Plugin operation gate: " + checks + " checks passed.");
            return 0;
        }
    }
}
