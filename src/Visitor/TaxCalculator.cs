namespace DesignPatternExamples.Visitor
{
    public class TaxCalculator 
    {
        public decimal Calculate(Bill bill)
        {
            var taxing = new ChargeTaxVisitor();
            var totalTax = 0M;
            foreach (var charge in bill.Charges)
            {
                totalTax += charge.Visit(taxing);
            }

            return totalTax;
        }
    }
}