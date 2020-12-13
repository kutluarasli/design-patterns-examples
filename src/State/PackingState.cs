using System;

namespace DesignPatternExamples.State
{
    public class PackingState : IState
    {
        public void SendEmail()
        {
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