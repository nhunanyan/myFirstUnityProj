using UnityEngine;
using System;

namespace Lesson5
{
    public class Timer
    {
        private readonly float _completeTime;
        public event Action OnComplete;
        private bool _isCompleted = false;

        public bool CheckCompletion()
        {
            if (_isCompleted) return false;
            if (_completeTime - Time.time > 0)
            {
                return false;
            }
            _isCompleted = true;
            OnComplete?.Invoke();
            return true;
        }

        public Timer(float time)
        {
            _completeTime = Time.time + time;
        }
    }
}