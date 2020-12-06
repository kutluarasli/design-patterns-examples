using System;

namespace DesignPatternExamples.FactoryMethod.Example2
{
    public class ConsoleLogger : ILogger
    {
        public void LogError(string log)
        {
            Console.WriteLine(log);
        }
    }
}