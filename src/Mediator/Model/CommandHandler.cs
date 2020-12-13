using System;
using System.Collections.Generic;
using System.Globalization;

namespace DesignPatternExamples.Mediator.Model
{
    public class CommandHandler : ICommandHandler
    {
        private readonly Dictionary<string, ISystemCommand> _commands; 
        
        public CommandHandler()
        {
            _commands = new Dictionary<string, ISystemCommand>();
            _commands.Add("hello", new SayHelloCommand());
            _commands.Add("weather", new CheckWeatherCommand());
            _commands.Add("exit", new ExitCommand());
        }

        public string ExecuteCommand(string command, Span<string> args)
        {
            var commandNormalized = command.ToLower(CultureInfo.InvariantCulture);
            if (_commands.ContainsKey(command))
            {
                return _commands[commandNormalized].Execute(args);
            }

            return "Unknown command";
        }
    }
}