using System;
using UnityEngine;

namespace Lesson5
{
    public class ConsoleLogger : MonoBehaviour
    {
        [SerializeField] private LogType logType;
        [SerializeField] private ReactiveLogger reactiveLogger;

        private void Start ()
        {
            reactiveLogger.OnLog += Print;
        }

        public void Print (LogType logs, string log)
        {
            if (logs != LogType.Log) return;
            Debug.Log(log);
        }
    }
}