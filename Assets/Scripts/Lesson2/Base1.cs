using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
namespace Lesson2{
    public abstract class Base1 : MonoBehaviour
    {
        [SerializeField] protected Vector3 values;
        public abstract void Rotate();
        void Update()
        {
            Rotate();
        }
        
        protected float ArrangeAngle(float angle, float between = 360f)
        {
            float newAngle = angle;
            if (Math.Abs(newAngle) > between)
            {
                return newAngle % between;
            }
            return angle;
        }
        
    }
}