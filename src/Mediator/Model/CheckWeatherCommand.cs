using System;

namespace DesignPatternExamples.Mediator.Model
{
    public class CheckWeatherCommand : ISystemCommand
    {
        public string Execute(Span<string> args)
        {
            return $"Today wheather is shiny in {args[0]}";
        }
    }
}