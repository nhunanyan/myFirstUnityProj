using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere2 : Base2
{
    public override void Rotate() {
        values.x = ArrangeAngle(values.x);
        values.y = ArrangeAngle(values.y);
        values.z = ArrangeAngle(values.z);
        transform.localRotation = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y, values.z);
    }

    void Update()
    {
        Rotate();
    }
}
