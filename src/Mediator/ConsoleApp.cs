

using DesignPatternExamples.Mediator.Model;

namespace DesignPatternExamples.Mediator
{
    public class ConsoleApp
    {
        public static void Main(string[] args)
        {
            var view = new View.ConsoleView();
            var commandHandler = new CommandHandler();
            var controller = new Controller.Controller(view, commandHandler);
            
            
            view.ReadCommand();
        }
    }
}