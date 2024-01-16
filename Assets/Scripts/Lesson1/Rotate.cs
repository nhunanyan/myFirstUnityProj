using UnityEngine;
using System;


public class Rotate : MonoBehaviour
{
    [SerializeField] private Vector3 values;

    private void Update()
    {
        values.x = ArrangeAngle(values.x);
        values.y = ArrangeAngle(values.y);
        values.z = ArrangeAngle(values.z);
        transform.localRotation = Quaternion.Euler(values);
    }
    private float ArrangeAngle(float angle, float between = 360f)
    {
        float newAngle = angle;
        if (Math.Abs(newAngle) > between)
        {
            return newAngle % between;
        }
        return angle;
    }

}
