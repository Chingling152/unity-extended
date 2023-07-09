using System;
using UnityEngine;

namespace UnityExtended.Unity.Extensions._3D
{
    public static class Vector3Extension
    {
        public static Vector3 ToAbsolute(this Vector3 vector3)
        {
            int x = Convert.ToInt32(Math.Abs(vector3.x));
            int y = Convert.ToInt32(Math.Abs(vector3.y));
            int z = Convert.ToInt32(Math.Abs(vector3.z));
            return new Vector3(x, y,z);
        }

        public static void FromAngle(this Vector3 vector3, int angle)
        {
            float angleRad = angle * (Mathf.PI / 180f);
            vector3.x = Mathf.Cos(angleRad);
            vector3.y = Mathf.Sin(angleRad);
        }

        /// <summary>
        /// Return the absolute angle of the target vector2
        /// </summary>
        /// <param name="vector2"></param>
        /// <param name="target"></param>
        /// <returns>The angle torwards target</returns>
        public static float GetAngle(this Vector3 vector3, Vector3 target)
        {
            var direction = target - vector3;
            return direction.ToAngle();
        }

        /// <summary>
        /// Converts the current Vector 2 to angle
        /// </summary>
        /// <param name="vector2"></param>
        /// <returns></returns>
        public static float ToAngle(this Vector3 vector3)
        {
            float angle = Mathf.Atan2(vector3.y, vector3.x) * Mathf.Rad2Deg;

            if (angle < 0) 
                angle += 360;

            return angle;
        }

    }
}