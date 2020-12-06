namespace DesignPatternExamples.FactoryMethod.Example2
{
    public class LoggingConfigurationSource
    {
        public virtual string ReadLoggerName()
        {
            return "DesignPatternExamples.FactoryMethod.Example2.ConsoleLogger";
        }
    }
}