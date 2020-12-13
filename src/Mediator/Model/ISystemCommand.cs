using System;

namespace DesignPatternExamples.Mediator.Model
{
    public interface  ISystemCommand
    {
        string Execute(Span<string> args);
    }
}