using System.Threading;

namespace DesignPatternExamples.Singleton
{
    public class BasicSingletonImpl
    {
        private static BasicSingletonImpl _instance;

        private BasicSingletonImpl()
        {
            Thread.Sleep(2);
        }

        public static BasicSingletonImpl GetObject()
        {
            if (_instance == null)
            {
                _instance = new BasicSingletonImpl();
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