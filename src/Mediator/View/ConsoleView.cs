using System;

namespace DesignPatternExamples.Mediator.View
{
    public class ConsoleView : IView
    {
        public event EventHandler<InputEnteredEventArg> OnInputEntered;
        
        public void ReadCommand()
        {
            while (true)
            {
                var consoleInput  = Console.ReadLine();

                if (!string.IsNullOrEmpty(consoleInput))
                {
                    NotifyInputEntered(consoleInput);
                }
            }
        }

        private void NotifyInputEntered(string? consoleInput)
        {
            if (OnInputEntered != null)
            {
                OnInputEntered(this, new InputEnteredEventArg { Input = consoleInput } );
            }
        }


        public void Write(string output)
        {
            Console.WriteLine(output);       
        }
    }
}