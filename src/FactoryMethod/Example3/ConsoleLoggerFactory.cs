namespace DesignPatternExamples.FactoryMethod.Example3
{
    public class ConsoleLoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            return new ConsoleLogger();
        }
    }
}