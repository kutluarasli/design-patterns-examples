using System;
using System.Net;

namespace DesignPatternExamples.ChainOfResponsibility.Example2
{
    public class UnknownExceptionHandler : ErrorHandler
    {

        private static UnknownExceptionHandler _instance;

        public static UnknownExceptionHandler Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UnknownExceptionHandler();
                }

                return _instance;
            }
        }

        public UnknownExceptionHandler() : base(false)
        {
        }

        protected override bool CanHandle(Exception exception)
        {
            return true;
        }

        protected override ErrorHandlingResult HandleErrorInternal(Exception exception)
        {
            return new ErrorHandlingResult
            {
                StatusCode = HttpStatusCode.InternalServerError,
                Message = "Unknown"
            };
        }
    }
}