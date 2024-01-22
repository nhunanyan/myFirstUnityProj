using System.Collections.Generic;
using UnityEngine;

namespace Lesson6
{
    public class List<T>
    {
        const int defaultArraySize = 4;
        private T[] _array;
        public int Capacity => _array.Length;
        public int Count { get; private set; }

        public List(int capacity = 0)
        {
            if (capacity < 0)
            {
                Debug.Log("The capacity of an array cannot be negative.");
                return;
            }
            if (capacity == 0)
            {
                capacity = defaultArraySize;
            }
            _array = new T[capacity];
            Count = 0;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                {
                    Debug.Log("There is not an element at that index!");
                }
                return _array[index];
            }

            set
            {
                if (index < 0 || index >= Count)
                {
                    Debug.Log("There is not an element at that index!");
                }
                _array[index] = value;
            }
        }

        public void Add(T element)
        {
            if (Count == Capacity)
            {
                var _newArray = new T[Capacity * 2];

                for (int i = 0; i < Count; ++i)
                {
                    _newArray[i] = _array[i];
                }
                _array = _newArray;
            }
            _array[Count] = element;
            Count++;
        }

        public bool Remove(T element)
        {
            int index = 0;
            bool found = false;

            for (int i = 0; i < Count; ++i)
            {
                if (!EqualityComparer<T>.Default.Equals(_array[i], element)) continue;
                index = i;
                found = true;
                break;
            }
            found = RemoveAt(index);
            return found;
        }

        public bool RemoveAt(int index)
        {
            if (index > Count) return false;
            Count--;
            for (int i = index; i < Count; ++i)
            {
                _array[i] = _array[i + 1];
            }
            return true;
        }

        public void AddRange(int from, List<T> list)
        {
            if (from >= Count)
            {
                Debug.Log("There is not an element at that index!");
                return;
            }
            var _newArray = new T[Count - from];
            for (int i = from; i < Count; ++i)
            {
                _newArray[i - from] = _array[i];
            }
            Count = from;
            for (int i = 0; i < list.Count; ++i)
            {
                Add(list[i]);
            }
            for (int i = 0; i < _newArray.Length; ++i)
            {
                Add(_newArray[i]);
            }
        }

        public bool RemoveRange(int from, int to)
        {
            if (from < 0 || to > Count)
            {
                Debug.Log("Reange out of ");
                return false;
            }
            var _newArray = new T[Count - to - 1];
            for (int i = to + 1; i < Count; ++i)
            {
                _newArray[i - to - 1] = _array[i];
            }
            Count = from;
            for (int i = 0; i < _newArray.Length; ++i)
            {
                Add(_newArray[i]);
            }
            return true;
        }

        public void Clear()
        {
            var _newArray = new T[Capacity];
            Count = 0;
            _array = _newArray;
        }
    }
}