using UnityEngine;
using System;
using TMPro;
using System.Linq.Expressions;

namespace Lesson5
{
    
    public enum LogType
    {
        Log,
        Warning,
        Error
    }
    
    public class ReactiveLogger : MonoBehaviour
    {
        [SerializeField] private float deley;
        private Timer _timer;
        private readonly LogType[] _logTypes = {LogType.Log, LogType.Warning, LogType.Error};
        private int _currontIndex;
        public event Action<LogType, string> OnLog;

        private void Update ()
        {
            if (_timer == null)
            {
                _timer = new Timer(deley);
                RegistorTimer(_timer);
                
            }
            _timer.CheckCompletion();
        
        }

        private void RegistorTimer (Timer timer)
        {
            timer.OnComplete += () => {
                    if (_currontIndex >= _logTypes.Length) 
                    {
                        _currontIndex = 0;
                    }
                    OnLog?.Invoke(_logTypes[_currontIndex], $"{_logTypes[_currontIndex].ToString()}, {DateTime.Now.ToString()}"   );
                    _currontIndex++;
                    _timer = new Timer(deley);
                    RegistorTimer(_timer);

            };
        }
    }
}


