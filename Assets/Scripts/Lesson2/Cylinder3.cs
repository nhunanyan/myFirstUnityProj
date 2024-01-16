using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Lesson2 {
    public class Cylinder3 : MonoBehaviour, IRotator
    {
        [SerializeField] protected Vector3 values;
        public void Rotate() {
            transform.localRotation = Quaternion.Euler(values.x.ArrangeAngle(), transform.eulerAngles.y.ArrangeAngle(), transform.eulerAngles.z.ArrangeAngle());
        }
    }
}