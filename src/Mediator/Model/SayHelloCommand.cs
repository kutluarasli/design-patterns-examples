using System;

namespace DesignPatternExamples.Mediator.Model
{
    public class SayHelloCommand : ISystemCommand
    {
        public string Execute(Span<string> args)
        {
            return $"Hello {args[0]}";
        }
    }
}