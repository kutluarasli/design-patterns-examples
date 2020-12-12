using System;
using System.Net;

namespace DesignPatternExamples.ChainOfResponsibility.Example2
{
    public class BusinessExceptionHandler : ErrorHandler
    {
        protected override bool CanHandle(Exception exception)
        {
            return exception is BusinessException;
        }

        protected override ErrorHandlingResult HandleErrorInternal(Exception exception)
        {
            return new ErrorHandlingResult
            {
                StatusCode = HttpStatusCode.BadRequest,
                Message = "BadRequest"
            };
        }
    }
}