using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Lesson2 {
    public class Base2 : MonoBehaviour
    {
        [SerializeField] protected Vector3 values;

        public virtual void Rotate() {
            values.x = values.x.ArrangeAngle();
            values.y = values.y.ArrangeAngle();
            values.z = values.z.ArrangeAngle();
            transform.localRotation = Quaternion.Euler(values);
        }
        private void Update()
        {
            Rotate();
        }
    }
}