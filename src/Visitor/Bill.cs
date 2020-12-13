using System.Collections.Generic;

namespace DesignPatternExamples.Visitor
{
    public class Bill
    {
        private List<Charge> _charges;
        public IReadOnlyList<Charge> Charges => _charges;

        public Bill()
        {
            _charges = new List<Charge>();
        }

        public void AddProductCharge(ProductCharge charge)
        {
            _charges.Add(charge);
        }

        public void AddServiceCharge(ServiceCharge charge)
        {
            _charges.Add(charge);
        }
    }
}