namespace DesignPatternExamples.Composite
{
    public class CompositeExpression : Expression
    {
        private readonly Expression _left;
        private readonly Expression _right;

        public CompositeExpression(Expression left, Expression right)
        {
            _left = left;
            _right = right;
        }
    }
}