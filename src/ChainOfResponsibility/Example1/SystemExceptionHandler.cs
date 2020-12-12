using System;
using System.Net;
using SystemException = DesignPatternExamples.ChainOfResponsibility.Example1.SystemException;

namespace DesignPatternExamples.ChainOfResponsibility.Example1
{
    public class SystemExceptionHandler : ErrorHandler
    {
        public SystemExceptionHandler(ErrorHandler next) : base(next)
        {
        }

        public override ErrorHandlingResult HandleError(Exception exception)
        {
            if (exception is SystemException)
            {
                return new ErrorHandlingResult
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    Message = "ServerError"
                };
            }

            return Next?.HandleError(exception);
        }
    }
}