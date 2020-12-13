namespace DesignPatternExamples.Visitor
{
    public class ChargeTaxVisitor : ChargeVisitor
    {
        public decimal TotalTax { get; private set; }
        
        public override decimal VisitProductCharge(ProductCharge charge)
        {
            return charge.Amount * 0.18M;
        }

        public override decimal VisitServiceCharge(ServiceCharge charge)
        {
            return charge.Amount * 0.08M;
        }
    }
}