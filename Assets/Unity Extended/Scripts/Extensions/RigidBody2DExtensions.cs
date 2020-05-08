using UnityEngine;

namespace UnityExtended.Extensions
{
    public static class Rigidbody2DExtension
    {
        /// <summary>
        /// Move the current RigidBody2D based on vertical and horizontal Forces
        /// </summary>
        /// <param name="rb">The body wich will be moved</param>
        /// <param name="verticalForce">Vertical force applied</param>
        /// <param name="horizontalForce">Horizontal force applied</param>
        /// <param name="speed">Force applied (affect horizontal and vertical forces)</param>
        public static void Move(this Rigidbody2D rb,float verticalForce,float horizontalForce,float speed = 1)
        {
            rb.AddForce(new Vector2(horizontalForce * speed,verticalForce * speed));
        }
    }
}
