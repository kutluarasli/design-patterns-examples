namespace DesignPatternExamples.Interpreter
{
    public abstract class CompositeExpression : Expression
    {
        private readonly Expression _left;
        private readonly Expression _right;

        protected Expression Left => _left;
        protected Expression Right => _right;

        public CompositeExpression(Expression left, Expression right)
        {
            _left = left;
            _right = right;
        }
    }
}