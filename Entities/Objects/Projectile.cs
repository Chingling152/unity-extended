using UnityEngine;

namespace Entities.Objects
{
    public abstract class Projectile : MonoBehaviour
    {
        /// <summary>
        /// Actual time of the Projectile
        /// </summary>
        protected float Timer = 0;

        /// <summary>
        /// Time to the projectile die
        /// </summary>
        [SerializeField]
        protected float MaxTimer = 5f;

        /// <summary>
        /// Max speed of the projectile
        /// </summary>
        [SerializeField]
        protected float MaxSpeed = 5f;

    }
}
