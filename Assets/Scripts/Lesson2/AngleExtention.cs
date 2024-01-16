using System;

namespace Lesson2 {
    public static class AngleExtention 
    {
        public static float ArrangeAngle(this float angle, float between = 360f)
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