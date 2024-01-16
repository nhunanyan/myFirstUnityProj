using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
namespace Lesson2{
    public abstract class Base1 : MonoBehaviour
    {
        [SerializeField] protected Vector3 values;
        
        public abstract void Rotate();

        private void Update()
        {
            Rotate();
        }
        
    }
}