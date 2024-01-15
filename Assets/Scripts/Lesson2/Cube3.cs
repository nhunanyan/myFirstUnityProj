using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube3 :  Base3, RotateInterface
{
    public void Rotate()
    {
        values.x = ArrangeAngle(values.x);
        values.y = ArrangeAngle(values.y);
        values.z = ArrangeAngle(values.z);
        transform.localRotation = Quaternion.Euler(transform.eulerAngles.x, values.y, transform.eulerAngles.z);
    }
    void Update () {
        Rotate();
    }
    
}
