using UnityEngine;

namespace UnityExtended.Unity._2D.Randomize
{
    public static class RigidBody2DRandomExtensions
    {
        /// <summary>
        /// Sets a Random physics 2D force
        /// </summary>
        /// <param name="rb"></param>
        /// <param name="force">Force applied</param>
        public static void RandomForce(this Rigidbody2D rb, float force = 5)
        {
            var vc = new Vector2(
                x: Random.Range(-1.0f, 1.0f), 
                y: Random.Range(-1.0f, 1.0f)
            );
            rb.AddForce(vc * force);
        }

        /// <summary>
        /// Sets a Random Rotation using physics
        /// </summary>
        /// <param name="rb"></param>
        /// <param name="force">Force Applied</param>
        public static void RandomTorque(this Rigidbody2D rb, float force = 5)
        {
            var vc = new Vector2(
                x: Random.Range(-1.0f, 1.0f),
                y: Random.Range(-1.0f, 1.0f)
            );
            rb.AddForceAtPosition(vc * force, Vector2.zero);
        }
    }
}
