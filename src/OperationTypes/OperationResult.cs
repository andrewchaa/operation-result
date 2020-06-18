using System;

namespace OperationTypes
{
    public class OperationResult<T>
    {
        public OperationStatus Status { get; }
        public T Result { get; }

        public OperationResult(OperationStatus status, T result)
        {
            Status = status;
            Result = result;
        }
    }

    public class OperationResult
    {
        public OperationStatus Status { get; }

        public OperationResult(OperationStatus status)
        {
            Status = status;
        }
    }
}

