using System;

namespace LAS_TERRAIN.Application
{
    internal enum OperationStatus
    {
        Success,
        Empty,
        Cancelled,
        Failed,
        Overflow
    }

    internal enum SectionStage
    {
        Collect,
        Filter,
        Deduplicate
    }

    internal sealed class OperationResult<T>
    {
        internal readonly OperationStatus Status;
        internal readonly T Value;
        internal readonly SectionStage Stage;
        internal readonly Exception Error;

        private OperationResult(OperationStatus status, T value, SectionStage stage, Exception error)
        {
            Status = status;
            Value = value;
            Stage = stage;
            Error = error;
        }

        internal static OperationResult<T> Succeeded(T value)
        {
            if (value == null) throw new ArgumentNullException("value");
            return new OperationResult<T>(OperationStatus.Success, value, SectionStage.Deduplicate, null);
        }

        internal static OperationResult<T> Empty()
        {
            return new OperationResult<T>(OperationStatus.Empty, default(T), SectionStage.Deduplicate, null);
        }

        internal static OperationResult<T> Cancelled(SectionStage stage)
        {
            return new OperationResult<T>(OperationStatus.Cancelled, default(T), stage, null);
        }

        internal static OperationResult<T> Failed(SectionStage stage, Exception error)
        {
            if (error == null) throw new ArgumentNullException("error");
            return new OperationResult<T>(OperationStatus.Failed, default(T), stage, error);
        }

        internal static OperationResult<T> Overflow(SectionStage stage, OutOfMemoryException error)
        {
            if (error == null) throw new ArgumentNullException("error");
            return new OperationResult<T>(OperationStatus.Overflow, default(T), stage, error);
        }
    }
}
