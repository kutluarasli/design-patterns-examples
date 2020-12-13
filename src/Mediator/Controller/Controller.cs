using System;
using System.Linq;
using DesignPatternExamples.Mediator.Model;
using DesignPatternExamples.Mediator.View;

namespace DesignPatternExamples.Mediator.Controller
{
    public class Controller
    {
        private readonly IView _view;
        private readonly ICommandHandler _commandHandler;

        public Controller(IView view, ICommandHandler commandHandler)
        {
            _view = view;
            _commandHandler = commandHandler;
            _view.OnInputEntered += ViewOnOnInputEntered;
        }

        private void ViewOnOnInputEntered(object? sender, InputEnteredEventArg e)
        {
            var pieces = e.Input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var command = pieces.First();
            var commandArguments = new Span<string>(pieces, 1, pieces.Length - 1);
            var output = _commandHandler.ExecuteCommand(command, commandArguments);
            
            _view.Write(output);
        }
    }
}