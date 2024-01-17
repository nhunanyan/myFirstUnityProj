using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lesson2 {
    public class Cylinder2 : Base2
    {
        public override void Rotate() 
        {   
            
            Vector3 targetAngles = new Vector3(values.x.ArrangeAngle(), transform.localRotation.y.ArrangeAngle(), transform.localRotation.z.ArrangeAngle());
            Quaternion rotation = Quaternion.Euler(targetAngles);
            transform.localRotation = rotation;
            


            //transform.localRotation = Quaternion.Euler(values.x.ArrangeAngle(), transform.eulerAngles.y.ArrangeAngle(), transform.eulerAngles.z.ArrangeAngle());
        }
    }
}