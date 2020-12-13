using System;

namespace DesignPatternExamples.State
{
    public class NewOrderState : IState
    {
        public void SendEmail()
        {
            Console.WriteLine("Your order has beed received");
        }

        public bool CanCancel()
        {
            return false;
        }

        public void Cancel()
        {
        }
    }
}