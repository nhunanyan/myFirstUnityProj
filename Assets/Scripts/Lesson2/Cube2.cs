using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lesson2 { 
    public class Cube2 : Base2
    {
        public override void Rotate() {
            transform.localRotation = Quaternion.Euler(transform.eulerAngles.x, values.y, transform.eulerAngles.z);
        }
    }
}