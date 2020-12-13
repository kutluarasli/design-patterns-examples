namespace DesignPatternExamples.Memento
{
    public class Game
    {
        public GameState Stop()
        {
            return new GameState();
        }

        public void Resume(GameState state)
        {
        }
    }
}