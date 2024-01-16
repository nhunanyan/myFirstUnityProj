using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lesson2 {
    class Sphere1 : Base1
    {
        public override void Rotate() {
            transform.localRotation = Quaternion.Euler(transform.eulerAngles.x.ArrangeAngle(), transform.eulerAngles.y.ArrangeAngle(), values.z.ArrangeAngle());
        }
    }
}