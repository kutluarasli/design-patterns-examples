using System.Collections;
using System.Collections.Generic;

namespace DesignPatternExamples.Iterator.Example1
{
    public class ImmutableListEnumerator<T> : IEnumerator<T>
    {
        private T[] _data;
        private int _currentIndex = -1;

        private int Next => _currentIndex + 1;

        public ImmutableListEnumerator(T[] data)
        {
            _data = data;
        }

        public bool MoveNext()
        {
            var result = _data.Length > Next;
            if (result)
            {
                _currentIndex = Next;
            }

            return result;
        }

        public void Reset()
        {
            _currentIndex = -1;
        }

        public T Current => _data[_currentIndex];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            _data = null;
        }
    }
}