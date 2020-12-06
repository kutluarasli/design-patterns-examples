using System;

namespace DesignPatternExamples.Prototype
{
    public class OrderDetail : ICloneable
    {
        public long Id { get; set; }

        public string Barcode { get; set; }

        public int Quantity { get; set; }
        
        public object Clone()
        {
            return new OrderDetail
            {
                Id = 0,
                Barcode = Barcode,
                Quantity = Quantity
            };
        }
    }
}