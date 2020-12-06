using System;
using System.Threading;

namespace DesignPatternExamples.Singleton
{
    public class SingletonWithLazyImpl
    {
        private static Lazy<SingletonWithLazyImpl> _lazySingleton = InitLazy();

        private SingletonWithLazyImpl()
        {
            Thread.Sleep(2);
        }

        public static SingletonWithLazyImpl GetObject()
        {
            return _lazySingleton.Value;
        }

        private static Lazy<SingletonWithLazyImpl> InitLazy()
        {
            return 
                new Lazy<SingletonWithLazyImpl>(() =>  new SingletonWithLazyImpl(), LazyThreadSafetyMode.ExecutionAndPublication);
        }

        /// <summary>
        /// For test purpose
        /// </summary>
        public static void Clear()
        {
            _lazySingleton = InitLazy();
        }
    }
}