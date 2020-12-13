namespace DesignPatternExamples.Visitor
{
    public class ServiceCharge : Charge
    {
        public override decimal Visit(ChargeVisitor visitor)
        {
           return visitor.VisitServiceCharge(this);
        }
    }
}