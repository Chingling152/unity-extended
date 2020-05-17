using System;
using UnityEngine;

namespace UnityExtended.Extensions
{
    public static class Vector3Extension
    {
        public static Vector3 ToAbsolute(this Vector3 vector2)
        {
            int x = Convert.ToInt32(Math.Abs(vector2.x));
            int y = Convert.ToInt32(Math.Abs(vector2.y));
            int z = Convert.ToInt32(Math.Abs(vector2.z));
            return new Vector3(x, y,z);
        }
    } 
}