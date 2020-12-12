using System;
using System.Net;

namespace DesignPatternExamples.ChainOfResponsibility.Example2
{
    public class SystemExceptionHandler : ErrorHandler
    {
        protected override bool CanHandle(Exception exception)
        {
            return exception is SystemException;
        }

        protected override ErrorHandlingResult HandleErrorInternal(Exception exception)
        {
            return new ErrorHandlingResult
            {
                StatusCode = HttpStatusCode.InternalServerError,
                Message = "ServerError"
            };
        }
    }
}