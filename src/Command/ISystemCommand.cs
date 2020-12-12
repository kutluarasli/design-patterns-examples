using System;

namespace DesignPatternExamples.Command
{
    public interface  ISystemCommand
    {
        void Execute(Span<string> args);
    }
}