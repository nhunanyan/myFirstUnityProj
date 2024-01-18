using UnityEngine;

namespace Lesson4
{
    public class ConsoleLogger : AbstractLogger
    {
        [SerializeField] private LogsSender logsSender;

        public override void Print (string log)
        {
            log += inspectorLogMes;
            Debug.Log(log);
        }

        private void Awake ()
        {
            logsSender.Register(this);
        }
    }
}