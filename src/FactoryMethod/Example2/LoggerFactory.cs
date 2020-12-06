using System;

namespace DesignPatternExamples.FactoryMethod.Example2
{
    public class LoggerFactory
    {
        private readonly LoggingConfigurationSource _configurationSource;

        public LoggerFactory(LoggingConfigurationSource configurationSource)
        {
            _configurationSource = configurationSource;
        }
        
        public ILogger CreateLogger()
        {
            var loggerName = _configurationSource.ReadLoggerName();
            if (string.IsNullOrWhiteSpace(loggerName))
            {
                loggerName = typeof(ConsoleLogger).FullName;
            }

            var loggerType = Type.GetType(loggerName!);
            var instance = Activator.CreateInstance(loggerType!);
            return (ILogger) instance;
        }
    }
}