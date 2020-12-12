using System;
using System.Collections.Generic;
using System.Globalization;

namespace DesignPatternExamples.Command
{
    public class CommandHandler
    {
        private readonly Dictionary<string, ISystemCommand> _commands; 
        
        public CommandHandler()
        {
            _commands = new Dictionary<string, ISystemCommand>();
            _commands.Add("hello", new SayHelloCommand());
            _commands.Add("weather", new CheckWeatherCommand());
        }

        public void ExecuteCommand(string command, Span<string> args)
        {
            var commandNormalized = command.ToLower(CultureInfo.InvariantCulture);
            if (_commands.ContainsKey(command))
            {
                _commands[commandNormalized].Execute(args);
            }
        }
    }
}