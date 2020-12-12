using System;

namespace DesignPatternExamples.Command
{
    public class CheckWeatherCommand : ISystemCommand
    {
        public void Execute(Span<string> args)
        {
            Console.WriteLine($"Today wheather is shiny in {args[0]}");
        }
    }
}