using System.Collections;
using UnityEngine;

namespace Lesson3 
{
    public class ConsoleLogger : MonoBehaviour, ILogger
    {
        private LogsSender _logSender;

        public void Print (string log) 
        {
            Debug.Log(log);
        }
        private void Awake ()
        {
            GameObject gameObject = new GameObject("LogsSender");
            _logSender = gameObject.AddComponent<LogsSender>();
            _logSender.Register(this);
        }
    }
}