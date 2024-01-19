using UnityEngine;
using System.IO;
using System;

namespace Lesson5
{
    public class FileLogger : MonoBehaviour
    {
        [SerializeField] private LogType logType;
        private string path = Application.dataPath + "/Scripts/Lesson5/Log.txt";
        [SerializeField] private ReactiveLogger reactiveLogger;

        private void Start ()
        {
            reactiveLogger.OnLog += Print;
        }

        private void Awake ()
        {
            if(!File.Exists(path)) 
            {
                File.Create(path);
            }
            File.WriteAllText(path, "");
        }

        public void Print (LogType logsType, string log)
        {
            if (logsType != LogType.Error) return;
            log = log + "\n";
            File.AppendAllText(path, log);
        }
    }
}