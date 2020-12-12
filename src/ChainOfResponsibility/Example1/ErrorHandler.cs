using System;

namespace DesignPatternExamples.ChainOfResponsibility.Example1
{
    public abstract class ErrorHandler
    {
        protected ErrorHandler Next { get; }

        protected ErrorHandler(ErrorHandler next)
        {
            Next = next;
        }

        public abstract ErrorHandlingResult HandleError(Exception exception);
    }
}