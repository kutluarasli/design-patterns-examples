namespace DesignPatternExamples.State
{
    public interface IState
    {
        void SendEmail();
        bool CanCancel();
        void Cancel();
    }
}