using System;

namespace DesignPatternExamples.State
{
    public class ShippedState : IState
    {
        public void SendEmail()
        {
            Console.WriteLine("Your order has been shipped");
        }

        public bool CanCancel()
        {
            return false;
        }

        public void Cancel()
        {
            throw new InvalidOperationException();
        }
    }
}