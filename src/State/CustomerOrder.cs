namespace DesignPatternExamples.State
{
    public class CustomerOrder
    {
        private IState _currentState;

        private CustomerOrder()
        {
            
        }

        public static CustomerOrder CreateNewOrder()
        {
            var newOrder = new CustomerOrder();
            newOrder.ChangeState(new NewOrderState());
            return newOrder;
        }

        public void ChangeState(IState newState)
        {
            _currentState = newState;
            newState.SendEmail();
        }

        public void Cancel()
        {
            _currentState.Cancel();
        }
    }
}