using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Base3 : MonoBehaviour
{
    [SerializeField] protected Vector3 values;
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
