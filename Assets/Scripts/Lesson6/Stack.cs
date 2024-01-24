using System.Collections.Generic;
using UnityEngine;

namespace Lesson6
{
    public class Stack<T>
    {
        private List<T> _list;
        private int _count;

        public void List ()
        {
            _list = new List<T>();
            _count = _list.Count;
        }

        public void Push (T element)
        {
            _list.Add(element);
            _count = _list.Count;
        }

        public T Pop ()
        {
            if (_count == 0)
            {
                Debug.Log("The stack is empty");
                return default;
            }
            T element = _list[_list.Count - 1];
            _list.RemoveAt(_list.Count - 1);
            _count = _list.Count;
            return element;
        }

        public T Pick ()
        {
            T element = _list[_list.Count - 1];
            return element;
        }

        public bool IsEmpty ()
        {
            if (_count == 0) return true;
            return false;
        }

        public void Clear ()
        {
            while (!IsEmpty())
            {
                Pop();
            }
        }
    }
}