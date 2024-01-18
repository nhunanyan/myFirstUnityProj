using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Lesson4
{
    public class UITextLogger : AbstractLogger
    {
        [SerializeField] private LogsSender logsSender;
        [SerializeField] private TMP_Text text;

        private void Awake()
        {
            text.text = "";
            logsSender.Register(this);
        }


        public override void Print(string log)
        {
            text.text = text.text + log + inspectorLogMes + "\n";
        }

    }
}