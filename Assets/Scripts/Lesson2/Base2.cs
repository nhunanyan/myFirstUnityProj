using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
namespace Lesson2 {
public class Base2 : MonoBehaviour
{
    [SerializeField] protected static Vector3 values;
    
    public virtual void Rotate() {
        values.x = values.x.ArrangeAngle();
        values.y = values.y.ArrangeAngle();
        values.z = values.z.ArrangeAngle();
        transform.localRotation = Quaternion.Euler(values);
    }
    private void Update()
    {
        Rotate();
    }
    /*
    protected float ArrangeAngle(float angle, float between = 360f)
    {
        float newAngle = angle;
        if (Math.Abs(newAngle) > between)
        {
            return newAngle % between;
        }
        return angle;
    }
    */
}
}