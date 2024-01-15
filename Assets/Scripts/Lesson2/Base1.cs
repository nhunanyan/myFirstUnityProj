using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

abstract class Base1 : MonoBehaviour
{
    [SerializeField] protected Vector3 values;
    public abstract void Rotate();
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
