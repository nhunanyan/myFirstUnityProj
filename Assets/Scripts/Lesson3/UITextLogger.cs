using TMPro;
using UnityEngine;
using UnityEngine.UI;
 
namespace Lesson3 
{
    public class UITextLogger : MonoBehaviour , ILogger 
    { 
        [SerializeField] private TMP_Text text;
        private LogsSender _logSender;

        public void Print (string log) {
            text.text = log;
        }

        private void Awake ()
        {
            GameObject gameObject = new GameObject("LogsSender");
            _logSender = gameObject.AddComponent<LogsSender>();
            _logSender.Register(this);
        }
    
    }
}