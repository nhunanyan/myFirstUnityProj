using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Base2 : MonoBehaviour
{
    [SerializeField] protected Vector3 values;
    public virtual void Rotate() {
        transform.localRotation = Quaternion.Euler(values);
    }
    protected float ArrangeAngle(float angle, float between = 360f)
    {
        float newAngle = angle;
        if (Math.Abs(newAngle) > between)
        {
            return newAngle % between;
        }
        return angle;
    }
}
