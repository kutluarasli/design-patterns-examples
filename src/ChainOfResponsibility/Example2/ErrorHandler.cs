using System;

namespace DesignPatternExamples.ChainOfResponsibility.Example2
{
    public abstract class ErrorHandler
    {
        private ErrorHandler _next;
        protected abstract bool CanHandle(Exception exception);
        protected abstract ErrorHandlingResult HandleErrorInternal(Exception exception);

        protected ErrorHandler(bool useDefaultNext)
        {
            if (useDefaultNext)
            {
                _next = UnknownExceptionHandler.Instance;;    
            }
        }

        protected ErrorHandler() : this(true)
        {
        }

        public ErrorHandlingResult HandleError(Exception exception)
        {
            if (CanHandle(exception))
            {
                return HandleErrorInternal(exception);
            }

            return _next?.HandleError(exception);
        }

        public ErrorHandler SetNext(ErrorHandler nextHandler)
        {
            _next = nextHandler;
            return nextHandler;
        }
    }
}