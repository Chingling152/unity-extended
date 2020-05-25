using UnityEngine;

namespace UnityExtended.Extensions.Unity
{
    public static class AnimatorExtensions
    {
        public static void SetRandomParameter(this Animator anim,string name,int variations)
        {
            if(variations <= 0) throw new System.Exception("Variations cannot be 0 or less");
            if(name == null) throw new System.ArgumentNullException("Name param cannot be null");
            
            anim.SetInteger(name,Random.Range(0,variations+1));
        }
    }
}
