namespace DesignPatternExamples.Interpreter
{
    public class Add : CompositeExpression
    {
        public Add(Expression left, Expression right) : base(left, right)
        {
        }

        public override int Calculate()
        {
            return Left + Right;
        }
    }
}