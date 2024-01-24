using System.Collections.Generic;
using UnityEngine;

namespace Lesson6
{
    public class Queue<T>
    {
        private List<T> _list;
        public int _count { get; private set; }

        public Queue()
        {
            _list = new List<T>();
            _count = _list.Count;
        }

        public void Enqueue(T element)
        {
            _list.Add(element);
            _count = _list.Count;
        }

        public T Dequeue()
        {
            if (_count == 0)
            {
                Debug.Log("The queue is empty");
                return default;
            }
            T element = _list[0];
            _list.RemoveAt(0);
            _count = _list.Count;
            return element;
        }

        public bool IsEmpty()
        {
            if (_count == 0) return true;
            return false;
        }

        public void Clear()
        {
            while (_count != 0)
            {
                Dequeue();
            }
        }
    }
}