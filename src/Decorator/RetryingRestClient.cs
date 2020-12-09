using System;

namespace DesignPatternExamples.Decorator
{
    public class RetryingRestClient : IRestClient
    {
        private readonly IRestClient _decoratedObject;

        public RetryingRestClient(IRestClient decoratedObject)
        {
            _decoratedObject = decoratedObject;
        }

        public object Get()
        {
            return GetInternal();
        }

        private object GetInternal(int retryCount = 0)
        {
            try
            {
                return _decoratedObject.Get();
            }
            catch (Exception)
            {
                if (retryCount < 2)
                {
                    return GetInternal(++retryCount);
                }

                throw;
            }
        }

        public object Post()
        {
            return _decoratedObject.Post();
        }
    }
}