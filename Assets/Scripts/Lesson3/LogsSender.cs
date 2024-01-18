using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System;

namespace Lesson3 
{
    public class LogsSender : MonoBehaviour
    {
        private List<ILogger> _loggers = new ();
        private float _time;

        public void Register(ILogger logger) 
        {
            _loggers.Add(logger);
        }

        private void Update ()
        {
            _time += Time.deltaTime;
            if (_time < 1) 
            {
                return;
            }
            _time = 0;
            foreach (ILogger logger in _loggers) 
            {
                logger.Print(logger.GetType().Name + " " + DateTime.Now.ToString());
            }
        }
    }
}