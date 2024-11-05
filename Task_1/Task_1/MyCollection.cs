using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class MyCollection<T> : ICollection<T>, ICollection
    {
        private T[] _values;

        public MyCollection(int capacity)
        {
            _values = new T[capacity];
        }

        public MyCollection() : this(10) { }

        public int Count { get; private set; } = 0;

        public bool IsReadOnly => throw new NotImplementedException();

        public bool IsSynchronized => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

        public void Add(T item)
        {
            if (Count == _values.Length)
            {
                T[] newArray = new T[Count * 2];
                Array.Copy(_values, newArray, Count);
                _values = newArray;
            }

            _values[Count++] = item;
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            //bool removed = false;
            //for (int i = 0; i < Count; i++)
            //{
            //    if (_values[i] == item)
            //        removed = true;

            //    if (removed && i + 1 < Count)
            //        _values[i] = _values[i + 1];
            //}
            //return removed;
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
