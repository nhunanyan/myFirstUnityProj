using UnityEngine;
using System.IO;

namespace Lesson3 
{
    public class FileLogger : MonoBehaviour, ILogger 
    {
        [SerializeField] private LogsSender _logSender;
        private string path = Application.dataPath + "/Scripts/Lesson3/Log.txt";

        public void Print(string log) 
        {
            log = log + "\n";
            File.AppendAllText(path, log);
        }

        private void Awake ()
        {
            if (!File.Exists(path)) 
            {
                File.Create(path);
            }
            File.WriteAllText(path, "");
            _logSender.Register(this);
        }
    }
}
