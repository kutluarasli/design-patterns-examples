namespace DesignPatternExamples.Observer
{
    public interface IInputEventPublisher
    { 
        void SubscribeInputEvent(IInputEventReceiver receiver);
        void UnsubscribeInputEvent(IInputEventReceiver receiver);
    }
}