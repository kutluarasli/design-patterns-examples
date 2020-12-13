using System.Collections.Generic;

namespace DesignPatternExamples.Observer
{
    public class View: IInputEventPublisher
    {
        private readonly List<IInputEventReceiver> _subscribers;

        public View()
        {
            _subscribers = new List<IInputEventReceiver>();
        }
        
        public void SubscribeInputEvent(IInputEventReceiver receiver)
        {
            if (!_subscribers.Contains(receiver))
            {
                _subscribers.Add(receiver);
            }
        }

        public void UnsubscribeInputEvent(IInputEventReceiver receiver)
        {
            if (_subscribers.Contains(receiver))
            {
                _subscribers.Remove(receiver);
            }
        }

        internal void NotifyInputEventListeners(string input)
        {
            _subscribers.ForEach(subs => subs.NotifyInput(input));
        }
    }
}