using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lesson2 {
    class Cube1 : Base1
    {
        public override void Rotate() {
            transform.localRotation = Quaternion.Euler(transform.eulerAngles.x.ArrangeAngle(), values.y.ArrangeAngle(), transform.eulerAngles.z.ArrangeAngle());
        }
    }
}