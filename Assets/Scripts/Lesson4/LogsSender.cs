using System.Collections.Generic;
using UnityEngine;
using System;

namespace Lesson4
{

    public class LogsSender : MonoBehaviour
    {
        private List<AbstractLogger> _loggers = new ();
        private float _time;

        public void Register(AbstractLogger logger) 
        {
            _loggers.Add(logger);
        }

        private void Update ()
        {
            _time += Time.deltaTime;
            if (_time < 1) return;
            _time = 0;
            foreach (AbstractLogger absLog in _loggers)
            {
                absLog.Print(absLog.GetType().Name + " " + DateTime.Now.ToString());
            }
        }
    }
}