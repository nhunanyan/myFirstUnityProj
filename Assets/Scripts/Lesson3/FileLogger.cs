using UnityEngine;
using System.IO;

namespace Lesson3 
{
    public class FileLogger : MonoBehaviour, ILogger 
    {
        private LogsSender _logSender;
        public void Print(string log) 
        {
            string path = Application.dataPath + "/Scripts/Lesson3/Log.txt";

            if (!File.Exists(path)) {
                File.WriteAllText(path, "");
            }
            File.AppendAllText(path, log);
        }

        private void Awake ()
        {
            GameObject gameObject = new GameObject("LogsSender");
            _logSender = gameObject.AddComponent<LogsSender>();
            _logSender.Register(this);
        }
    }
}
