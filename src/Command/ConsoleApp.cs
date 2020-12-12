using System;
using System.Linq;

namespace DesignPatternExamples.Command
{
    public class ConsoleApp
    {
        public static void Main(string[] args)
        {
            var command = args.FirstOrDefault();
            if (command == null)
            {
                Console.WriteLine("Command not recognized");
                return;
            }

            var commandArguments = new Span<string>(args, 1, args.Length -1);
            var commandHandler  = new CommandHandler();
            commandHandler.ExecuteCommand(command, commandArguments);
            Console.ReadKey();
        }
    }
}