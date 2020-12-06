using System;

namespace DesignPatternExamples.FactoryMethod.Example3
{
    public class ConsoleLogger : ILogger
    {
        public void LogError(string log)
        {
            Console.WriteLine(log);
        }
    }
}