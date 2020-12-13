using System;

namespace DesignPatternExamples.Mediator.View
{
    public class InputEnteredEventArg: EventArgs
    {
        public string Input { get; set; }
    }
}