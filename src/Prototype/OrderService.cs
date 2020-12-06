namespace DesignPatternExamples.Prototype
{
    public class OrderService
    {
        public void DuplicateOrder(Order prototypeOrder)
        {
            var newOrder =  (Order) prototypeOrder.Clone();
            SaveNewOrder(newOrder);
        }

        private void SaveNewOrder(Order newOrder)
        {
            // Takes an existing order objects and uses it as a template object to create a new order originating from the base.
        }
    }
}