using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Lesson2 {
    public class Cube3 :  MonoBehaviour, IRotator
    {
        [SerializeField] protected Vector3 values;
        public void Rotate()
        {
            transform.localRotation = Quaternion.Euler(transform.eulerAngles.x.ArrangeAngle(), values.y.ArrangeAngle(), transform.eulerAngles.z.ArrangeAngle());
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