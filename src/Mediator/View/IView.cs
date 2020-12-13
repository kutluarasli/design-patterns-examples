using System;

namespace DesignPatternExamples.Mediator.View
{
    public interface IView
    {
        void ReadCommand();

        event EventHandler<InputEnteredEventArg> OnInputEntered;
        
        void Write(string output);
    }
}