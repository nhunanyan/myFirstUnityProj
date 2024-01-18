using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
 
namespace Lesson3 
{
    public class UITextLogger : MonoBehaviour , ILogger 
    { 
        [SerializeField] private TMP_Text text;
        [SerializeField] private LogsSender _logSender;
        private String newText;

        public void Print (string log) {
            text.text = text.text + "\n" + log;
        }

        private void Awake ()
        {
            text.text = "";
            _logSender.Register(this);
        }
    
    }
}