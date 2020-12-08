namespace DesignPatternExamples.Composite
{
    public class Minus : CompositeExpression
    {
        public Minus(Expression left, Expression right) : base(left, right)
        {
        }
    }
}