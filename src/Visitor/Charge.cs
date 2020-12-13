namespace DesignPatternExamples.Visitor
{
    public abstract class Charge
    {
        public decimal Amount { get; set; }

        public virtual decimal Visit(ChargeVisitor visitor)
        {
            return 0;
        }
    }
}