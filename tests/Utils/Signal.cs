using System.Collections.Generic;
using System.Linq;

namespace DesignPatternExamples.Tests.Utils
{
    public class Signal
    {
        private readonly IList<ISignalListener> _listeners;

        public Signal()
        {
            _listeners = new List<ISignalListener>();
        }

        public void Subscribe(ISignalListener listener)
        {
            _listeners.Add(listener);
        }

        public void Alarm()
        {
            _listeners.AsParallel().ForAll(listener => listener.Notify());
        }
    }
}