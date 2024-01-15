using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] float rotateX;
    [SerializeField] float rotateY;
    [SerializeField] float rotateZ;
    
    void Start()
    {
        if(rotateX > 360) {
            rotateX -= 360;
        }
        else if (rotateY > 360) {
            rotateY -= 360;
        }
        else if (rotateZ > 360) {
            rotateZ -= 360;
        }
        else if (rotateY < -360) {
            rotateY += 360;
        }
        else if (rotateZ < -360) {
            rotateZ += 360;
        }
        else if (rotateX < -360) {
            rotateX += 360;
        }
        transform.localRotation = Quaternion.Euler(rotateX, rotateY, rotateZ);
    }

}
