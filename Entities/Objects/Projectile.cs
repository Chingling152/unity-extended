using UnityEngine;

namespace Entities.Objects
{
    public class Projectile : MonoBehaviour
    {
        /// <summary>
        /// Actual time of the Projectile
        /// </summary>
        protected float Timer = 0;

        /// <summary>
        /// Actual time of the Projectile
        /// </summary>
        [SerializeField]
        protected float MaxTimer = 5f;

        [SerializeField]
        protected float MaxSpeed = 5f;

    }
}
