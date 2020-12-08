namespace DesignPatternExamples.Composite
{
    public class Multiply: CompositeExpression
    {
        public Multiply(Expression left, Expression right) : base(left, right)
        {
        }
    }
}