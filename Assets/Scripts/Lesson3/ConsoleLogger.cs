using System.Collections;
using UnityEngine;

namespace Lesson3 
{
    public class ConsoleLogger : MonoBehaviour, ILogger
    {
        [SerializeField] private LogsSender _logSender;
    
        public void Print (string log) 
        {
            Debug.Log(log);
        }
        private void Awake ()
        {
            _logSender.Register(this);
        }
    }
}