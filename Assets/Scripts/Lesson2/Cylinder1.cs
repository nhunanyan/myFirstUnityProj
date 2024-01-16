using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lesson2 {
    class Cylinder1 : Base1
    {
        public override void Rotate() {
            transform.localRotation = Quaternion.Euler(values.x.ArrangeAngle(), transform.eulerAngles.y.ArrangeAngle(), transform.eulerAngles.z.ArrangeAngle());
        }   
    }
}