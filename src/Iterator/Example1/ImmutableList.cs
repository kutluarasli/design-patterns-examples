using System.Collections;
using System.Collections.Generic;

namespace DesignPatternExamples.Iterator.Example1
{
    public class ImmutableList<T> : IEnumerable<T>
    {
        private T[] _data;

        public ImmutableList(T[] data)
        {
            _data = data;
        }

        public virtual IEnumerator<T> GetEnumerator()
        {
            return new ImmutableListEnumerator<T>(_data);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}