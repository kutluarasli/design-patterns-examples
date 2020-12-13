namespace DesignPatternExamples.Visitor
{
    public abstract class ChargeVisitor
    {
        public virtual decimal VisitProductCharge(ProductCharge charge)
        {
            return 0;
        }

        public virtual decimal VisitServiceCharge(ServiceCharge charge)
        {
            return 0;
        }
    }
}