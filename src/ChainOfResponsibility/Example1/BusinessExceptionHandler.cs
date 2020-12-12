using System;
using System.Net;

namespace DesignPatternExamples.ChainOfResponsibility.Example1
{
    public class BusinessExceptionHandler : ErrorHandler
    {
        public BusinessExceptionHandler(ErrorHandler next) : base(next)
        {
        }

        public override ErrorHandlingResult HandleError(Exception exception)
        {
            if (exception is BusinessException)
            {
                return new ErrorHandlingResult
                {
                    StatusCode = HttpStatusCode.BadRequest,
                    Message = "BadRequest"
                };
            }

            return Next?.HandleError(exception);
        }
    }
}