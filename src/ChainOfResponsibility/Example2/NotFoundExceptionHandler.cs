using System;
using System.Net;

namespace DesignPatternExamples.ChainOfResponsibility.Example2
{
    public class NotFoundExceptionHandler: ErrorHandler
    {
        protected override bool CanHandle(Exception exception)
        {
            return exception is NotFoundException;
        }

        protected override ErrorHandlingResult HandleErrorInternal(Exception exception)
        {
            return new ErrorHandlingResult
            {
                StatusCode = HttpStatusCode.NotFound,
                Message = "NotFound"
            };
        }
    }
}