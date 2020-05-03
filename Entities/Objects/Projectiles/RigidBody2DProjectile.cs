using Entities.Alive;
using UnityEngine;

namespace Entities.Objects.Projectiles
{
    public class RigidBody2DProjectile : Projectile
    {
        public BaseEntity Owner;

        private void Awake()
        {
            this.GetComponent<Rigidbody2D>().AddForce(this.transform.right * MaxSpeed);//TODO : Change to transform.up 
        }
    }
}
