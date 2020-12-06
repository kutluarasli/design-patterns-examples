using System.Threading;

namespace DesignPatternExamples.Singleton
{
    public class SingletonWithDoubleCheckImpl
    {
        private static readonly object _lock = new object();
        private static SingletonWithDoubleCheckImpl _instance;
        
        private SingletonWithDoubleCheckImpl()
        {
            Thread.Sleep(2);
        }

        public static SingletonWithDoubleCheckImpl GetObject()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new SingletonWithDoubleCheckImpl();
                    }
                }
            }
            return _instance;
        }

        /// <summary>
        /// For test purpose
        /// </summary>
        public static void Clear()
        {
            _instance = null;
        }
    }
}