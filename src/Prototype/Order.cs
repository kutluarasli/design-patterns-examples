using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatternExamples.Prototype
{
    public class Order : ICloneable
    {
        public long Id { get; set; }
        
        public string CustomerName { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
        
        public object Clone()
        {
            return new Order
            {
                Id = 0,
                CustomerName = CustomerName,
                OrderDetails = OrderDetails.Select(x => (OrderDetail) x.Clone()).ToList()
            };
        }
    }
}