using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

namespace Lesson6
{
    public class Dictionary<T, U> : IEnumerable
    {
        private struct Entery
        {
            public int hashCode;
            public T key;
            public U value;
        }

        private List<Entery> _entery;
        private int _count;

        public int Count => _count;

        public Dictionary()
        {
            _entery = new List<Entery>();
            _count = 0;
        }


        public U this[T key]
        {
            get
            {
                if (!IsInDictionary(key))
                {
                    Debug.Log("This key is not in the dictionary!");
                    return default;
                }
                foreach (Entery element in _entery)
                {
                    if (element.hashCode != key.GetHashCode())
                    {
                        continue;
                    }
                    return element.value;
                }
                return default;
            }

            set
            {
                if (!IsInDictionary(key))
                {
                    Add(key, value);
                }
                for (int i = 0; i < _entery.Count; i++)
                {
                    var entry = _entery[i];
                    if (entry.hashCode == key.GetHashCode())
                    {
                        entry.value = value;
                    }
                }
            }
        }

        private bool IsInDictionary(T key)
        {
            foreach (Entery element in _entery)
            {
                if (element.hashCode == key.GetHashCode()) return true;
            }
            return false;
        }


        public void Add(T key, U value)
        {
            if (IsInDictionary(key))
            {
                Debug.Log("this key already exists in the dictionary!");
                return;
            }
            Entery element = new Entery();
            element.hashCode = key.GetHashCode();
            element.key = key;
            element.value = value;
            _entery.Add(element);
            _count++;
            var item = _entery[_entery.Count];
        }

        public void Clear()
        {
            _entery.Clear();
            _count = 0;
        }

        public void Remove(T key)
        {
            if (!IsInDictionary(key))
            {
                Debug.Log("This key is not in the dictionary!");
                return;
            }

            for (int i = 0; i < _entery.Count; ++i)
            {
                var entry = _entery[i];
                if (entry.hashCode == key.GetHashCode())
                {
                    if (i != 0)
                    {
                        var tmp = _entery[i - 1];
                    }
                    _entery.Remove(entry);
                    return;
                }
            }
            _count--;
        }

        private Entery GetEntery(int hashCode)
        {
            for (int i = 0; i < _entery.Count; ++i)
            {
                var entry = _entery[i];
                if (entry.hashCode == hashCode)
                {
                    return entry;
                }
            }
            return default;
        }

        public class ForwardIterator : IEnumerator, IEnumerator<KeyValuePair<T,U>>
        {
            private Dictionary<T, U> _dictionary;
            private Entery _item=>_dictionary._entery[_index];

            public object Current => _item;
            private int _index;

            KeyValuePair<T,U> IEnumerator<KeyValuePair<T,U>>.Current => new KeyValuePair<T, U>(_item.key,_item.value);

            public ForwardIterator(Dictionary<T, U> dictionary)
            {
                _dictionary = dictionary;
                _index=-1;
            }

            public void Reset()
            {
                _index=-1;
            }

            public bool MoveNext()
            {
                _index++;
                if(_index>=_dictionary._entery.Count){
                    return false;
                }
                return true;
            }


            public void Dispose()
            {
                Reset();
                _dictionary=null;
            }

        }
        
        public IEnumerator GetEnumerator()
        {
            return new ForwardIterator(this);
        }

    }
}