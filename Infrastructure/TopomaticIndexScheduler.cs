using System;

namespace LAS_TERRAIN.Infrastructure
{
    // Keep the synchronous phase barriers outside the numerical filter while
    // forwarding worker failures and joining every worker on .NET 3.5.
    internal static class TopomaticIndexScheduler
    {
        internal static void ForEach(int count, Action<int> body)
        {
            if (body == null) throw new ArgumentNullException("body");
            ParallelWorkRunner.Run(count, true,
                delegate(int i, WorkCancellation stop) { body(i); },
                null, null);
        }
    }
}
