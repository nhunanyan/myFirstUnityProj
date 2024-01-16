using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Lesson2 {
    public class Base3 : MonoBehaviour
    {
        
        [SerializeField] protected List<GameObject> rotatableGameObject;
        private List<IRotator> _rotatobals = new();

        private void Awake() {
            foreach (GameObject rbo in rotatableGameObject) {
                IRotator rotator = rbo.GetComponent<IRotator>();
                _rotatobals.Add(rotator);
            }
        }

        private void Update() {
            foreach (IRotator rotatoble in _rotatobals) {
                rotatoble.Rotate();
            }
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
}