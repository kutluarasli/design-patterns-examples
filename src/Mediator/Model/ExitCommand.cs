using System;

namespace DesignPatternExamples.Mediator.Model
{
    public class ExitCommand : ISystemCommand
    {
        public string Execute(Span<string> args)
        {
            throw new ApplicationException("Terminate");
        }
    }
}