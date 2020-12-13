using System;
using System.Linq;

namespace DesignPatternExamples.Memento
{
    public class GameLauncher
    {
/*
        public static void Main(string[] args)
        {
            var game = new Game();
            if (args.Length > 0)
            {
                var gameState = ReadPersistedState(args.First());
                game.Resume(gameState);
            }

            Console.Read();
        }
*/
        private static GameState ReadPersistedState(string file)
        {
            return new GameState();
        }
    }
}