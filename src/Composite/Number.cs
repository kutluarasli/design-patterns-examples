namespace DesignPatternExamples.Composite
{
    public class Number : Expression
    {
        private readonly int _number;

        public Number(int number)
        {
            _number = number;
        }
    }
}