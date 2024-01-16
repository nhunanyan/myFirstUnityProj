using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lesson2 {
    public class Sphere2 : Base2
    {
        public override void Rotate() 
        {
            transform.localRotation = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y, values.z);
        }

        void Update()
        {
            Rotate();
        }
    }
}