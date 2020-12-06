using System.Threading;

namespace DesignPatternExamples.Singleton
{
    public class SingletonWithStaticConsImpl
    {
        private static SingletonWithStaticConsImpl _instance;

        static SingletonWithStaticConsImpl()
        {
          _instance = new SingletonWithStaticConsImpl();
        }

        private SingletonWithStaticConsImpl()
        {
            Thread.Sleep(2);
        }

        public static SingletonWithStaticConsImpl GetObject()
        {
            return _instance;
        }
    }
}