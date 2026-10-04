using System;

namespace Topomatic.Cad.View
{
    public sealed class CadView { }
}

namespace Topomatic.Controls
{
    public static class WaitProgress
    {
        public static bool CancellationPending;
        public static int ProgressCalls;
        public static int CancelOnCall;
        public static int ThrowOnCall;
        public static Action<float> OnProgress;

        public static void Reset()
        {
            CancellationPending = false;
            ProgressCalls = 0;
            CancelOnCall = 0;
            ThrowOnCall = 0;
            OnProgress = null;
        }

        public static void ProgressChange(float value)
        {
            ProgressCalls++;
            if (OnProgress != null) OnProgress(value);
            if (ProgressCalls == CancelOnCall) CancellationPending = true;
            if (ProgressCalls == ThrowOnCall)
                throw new ApplicationException("progress sentinel");
        }
    }
}

namespace LAS_TERRAIN.Infrastructure
{
    public static class UserDialogs
    {
        public static string SavePath;
        public static int InfoCalls;

        public static string GetSaveFilePath(string title)
        {
            return SavePath;
        }

        public static void ShowInfo(string message)
        {
            InfoCalls++;
        }
    }
}
