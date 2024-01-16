using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lesson2 {
    public class Cylinder2 : Base2
    {
        public override void Rotate() 
        {   
            transform.localRotation = Quaternion.Euler(values.x.ArrangeAngle(), transform.eulerAngles.y.ArrangeAngle(), transform.eulerAngles.z.ArrangeAngle());
        }
    }
}