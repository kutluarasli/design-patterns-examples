namespace DesignPatternExamples.Interpreter
{
    public class Multiply: CompositeExpression
    {
        public Multiply(Expression left, Expression right) : base(left, right)
        {
        }


        public override int Calculate()
        {
            return Left * Right;
        }
    }
}