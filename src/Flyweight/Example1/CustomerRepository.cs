using System.Collections.Generic;

namespace DesignPatternExamples.Flyweight.Example1
{
    public class CustomerRepository
    {
        private readonly Dictionary<long, Customer> _customerCache;

        public CustomerRepository()
        {
            _customerCache = new Dictionary<long, Customer>();
        }

        public Customer LoadCustomer(long id)
        {
            if (!_customerCache.ContainsKey(id))
            {
                var customer = LoadFromDatabase(id);
                _customerCache.Add(id, customer);
            }

            return _customerCache[id];
        }

        private Customer LoadFromDatabase(in long id)
        {
            return new Customer {Id = id};
        }
    }
}