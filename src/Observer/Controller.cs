namespace DesignPatternExamples.Observer
{
    public class Controller : IInputEventReceiver
    {
        private readonly View _view;
        internal string _lastestInput;

        public Controller(View view)
        {
            _view = view;
            view.SubscribeInputEvent(this);
        }
        
        
        public void NotifyInput(string input)
        {
            _lastestInput = input;
        }
    }
}