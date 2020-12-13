namespace DesignPatternExamples.Visitor
{
    public class ProductCharge : Charge
    {
        public override decimal Visit(ChargeVisitor visitor)
        {
            return visitor.VisitProductCharge(this);
        }
    }
}