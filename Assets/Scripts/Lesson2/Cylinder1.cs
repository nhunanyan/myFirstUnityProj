using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Cylinder1 : Base1
{
    public override void Rotate() {
        values.x = ArrangeAngle(values.x);
        values.y = ArrangeAngle(values.y);
        values.z = ArrangeAngle(values.z);
        transform.localRotation = Quaternion.Euler(values.x, transform.eulerAngles.y, transform.eulerAngles.z);
    }

    void Update()
    {
        Rotate();
    }
}
