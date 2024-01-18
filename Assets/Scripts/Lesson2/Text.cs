using UnityEngine;

namespace Lesson2 {
    public class Text : MonoBehaviour, IRotator
    {
        [SerializeField] protected Vector3 values;
        public void Rotate() {
            transform.localRotation = Quaternion.Euler(transform.eulerAngles.x.ArrangeAngle(), transform.eulerAngles.y.ArrangeAngle(), values.z.ArrangeAngle());
        }
        
    }
}