using System;

namespace DesignPatternExamples.Command
{
    public class SayHelloCommand : ISystemCommand
    {
        public void Execute(Span<string> args)
        {
            Console.WriteLine($"Hello {args[0]}");
        }
    }
}