namespace DesignPatternExamples.Interpreter
{
    public class Minus : CompositeExpression
    {
        public Minus(Expression left, Expression right) : base(left, right)
        {
        }

        public override int Calculate()
        {
            return Left - Right;
        }
    }
}