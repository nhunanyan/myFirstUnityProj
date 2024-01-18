using UnityEngine;
using System.IO;

namespace Lesson4
{
    public class FileLogger : AbstractLogger
    {
        [SerializeField] private LogsSender logsSender;
        private string path = Application.dataPath + "/Scripts/Lesson4/Log.txt";

        public override void Print(string log)
        {
            log = log + inspectorLogMes + "\n";
            File.AppendAllText(path, log);
        }

        private void Awake ()
        {
            if(!File.Exists(path)) 
            {
                File.Create(path);
            }
            File.WriteAllText(path, "");
            logsSender.Register(this);
        }
    }
}