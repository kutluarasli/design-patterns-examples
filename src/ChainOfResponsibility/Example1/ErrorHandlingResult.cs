using System.Net;

namespace DesignPatternExamples.ChainOfResponsibility.Example1
{
    public class ErrorHandlingResult
    {
        public HttpStatusCode StatusCode { get; set; }
        public string Message { get; set; }
    }
}