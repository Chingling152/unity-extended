using System;
using UnityEngine;

namespace UnityExtended.Unity.Randomize
{
    public static class AnimatorRandomExtensions
    {
        public static void SetRandomParameter(this Animator anim,string name,int variations)
        {
            if(variations <= 0) 
                throw new ArgumentException("Variations cannot be 0 or less");
            if(name == null) 
                throw new ArgumentNullException(nameof(name),"Name param cannot be null");

            var randomIndex = UnityEngine.Random.Range(0, variations + 1);
            anim.SetInteger(name, randomIndex);
        }
    }
}
