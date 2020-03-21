using System;
using UnityEngine;

namespace Colver.Main
{
    /// <summary>
    /// Class used to create more methos to Vector2 class
    /// </summary>
    public static class Vector2Extension
    {
        /// <summary>
        /// Convert the current Vector2 to absolute integer Values
        /// </summary>
        /// <param name="vector2">Vector2 to to be conveted</param>
        /// <returns>Return a Vector 2 with positive integer number</returns>
        public static Vector2 ToAbsolute(this Vector2 vector2)
        {
            int x = Convert.ToInt32(Math.Abs(vector2.x));
            int y = Convert.ToInt32(Math.Abs(vector2.y));

            return new Vector2(x, y);
        }

        /// <summary>
        /// Verify if two Vector2 has the same x and the same Y
        /// </summary>
        /// <param name="vector2">The first Vector 2</param>
        /// <param name="obj">The second Vector 2</param>
        /// <returns>Returns true if the x and the y of the first and the second one are equals</returns>
        public static bool Equals(this Vector2 vector2, Vector2 obj) => vector2.ToAbsolute().x == obj.ToAbsolute().x && vector2.ToAbsolute().y == obj.ToAbsolute().y;

        /// <summary>
        /// Verify if the first Vector is Greater than the second one
        /// </summary>
        /// <param name="vector2">First Vector2</param>
        /// <param name="obj">Second Vector2</param>
        /// <returns>Returns true if the x or the y of the first are grat than x and y of second one</returns>
        public static bool GreaterThan(this Vector2 vector2, Vector2 obj) => vector2.ToAbsolute().x > obj.ToAbsolute().x || vector2.ToAbsolute().y > obj.ToAbsolute().y;
    }

}
