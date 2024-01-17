using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System;

namespace Lesson3 
{
    public class LogsSender : MonoBehaviour
    {
        private List<ILogger> _loggers = new ();

        public void Register(ILogger logger) 
        {
            Debug.Log("i want register");
            _loggers.Add(logger);
        }

        private IEnumerator WaitSecond () 
        {
            yield return new WaitForSeconds(1);
        }

        private void Update ()
        {
            StartCoroutine(WaitSecond());
            foreach (ILogger logger in _loggers) 
            {
                logger.Print(logger.GetType().Name + " " +DateTime.Now.ToString());
            }
        }
    }
}