using System;
using System.Net;

namespace DesignPatternExamples.ChainOfResponsibility.Example1
{
    public class NotFoundExceptionHandler: ErrorHandler
    {
        public NotFoundExceptionHandler(ErrorHandler next) : base(next)
        {
        }

        public override ErrorHandlingResult HandleError(Exception exception)
        {
            if (exception is NotFoundException)
            {
                return new ErrorHandlingResult
                {
                    StatusCode = HttpStatusCode.NotFound,
                    Message = "NotFound"
                };
            }

            return Next?.HandleError(exception);
        }
    }
}