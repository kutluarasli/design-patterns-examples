using System;

namespace DesignPatternExamples.Mediator.Model
{
    public interface ICommandHandler
    {
        string ExecuteCommand(string command, Span<string> args);
    }
}