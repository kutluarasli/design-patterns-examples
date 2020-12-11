namespace DesignPatternExamples.Interpreter
{
    public class Number : Expression
    {
        private readonly int _number;

        public Number(int number)
        {
            _number = number;
        }

        public override int Calculate()
        {
            return _number;
        }
    }
}