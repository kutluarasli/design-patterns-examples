namespace DesignPatternExamples.Interpreter
{
    public abstract class Expression
    {
        public abstract int Calculate();
        
        public static implicit operator int(Expression expression)
        {
            return expression.Calculate();
        }
    }
}