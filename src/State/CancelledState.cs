using System;

namespace DesignPatternExamples.State
{
    public class CancelledState : IState
    {
        public void SendEmail()
        {
            Console.WriteLine("Your order has been cancelled");
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