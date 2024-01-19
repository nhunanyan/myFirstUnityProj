using TMPro;
using UnityEngine;
using System;

namespace Lesson5
{
    public class UITextLogger : MonoBehaviour
    {
        [SerializeField] private LogType logType;
        [SerializeField] private TMP_Text text;
        [SerializeField] private ReactiveLogger reactiveLogger;

        private void Start ()
        {
            reactiveLogger.OnLog += Print;
        }

        private void Awake()
        {
            text.text = "";
        }


        public void Print (LogType logsType, string log)
        {
            if (logsType != LogType.Warning) return;
            text.text = text.text + log + "\n";
        }

    }
}