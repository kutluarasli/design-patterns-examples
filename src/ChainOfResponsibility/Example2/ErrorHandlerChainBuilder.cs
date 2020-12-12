namespace DesignPatternExamples.ChainOfResponsibility.Example2
{
    public class ErrorHandlerChainBuilder
    {
        private readonly ErrorHandler _head;
        private ErrorHandler _tail;

        public ErrorHandlerChainBuilder(ErrorHandler head)
        {
            _head = head;
            _tail = head;
        }

        public ErrorHandlerChainBuilder With(ErrorHandler errorHandler)
        {
            _tail = _head.SetNext(errorHandler);
            return this;
        }

        public ErrorHandler Build()
        {
            return _tail;
        }
    }
}