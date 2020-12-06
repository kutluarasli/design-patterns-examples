using System;
using System.Collections.Generic;
using System.Threading;
using DesignPatternExamples.Tests.Utils;

namespace DesignPatternExamples.Tests.Singleton
{
    public static class MultiThreadSingletonEnvironment<T> where T: class
    {
        public static List<object> Run(int numberOfThreads, Func<T> singletonFunc)
        {
            var signal = new Signal();
            var consumer = new SingletonConsumerClass<T>(singletonFunc);
            signal.Subscribe(consumer);

            var listOfCreatedObjects = new List<object>();
            for (int i = 0; i < numberOfThreads; i++)
            {
                var newThread = new Thread(() =>
                {
                    var singletonObject = consumer.UseObject();
                    listOfCreatedObjects.Add(singletonObject);
                });
                newThread.Start();
            }

            //Act
            signal.Alarm();
            Thread.Sleep(10);

            return listOfCreatedObjects;
        }
    }
    
    public class SingletonConsumerClass<T> : ISignalListener where T: class
    {
        private volatile bool _signalReceived;
        private Func<T> _singletonFunc;

        public SingletonConsumerClass(Func<T> singletonFunc)
        {
            _singletonFunc = singletonFunc;
        }

        public object UseObject()
        {
            if (!_signalReceived)
            {
                Thread.Sleep(1);
            }

            return _singletonFunc();
        }

        public void Notify()
        {
            _signalReceived = true;
        }
    }
}