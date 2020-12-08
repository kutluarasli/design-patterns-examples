namespace DesignPatternExamples.Composite
{
    public class Add : CompositeExpression
    {
        public Add(Expression left, Expression right) : base(left, right)
        {
        }
    }
}