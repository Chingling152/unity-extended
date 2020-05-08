using UnityEngine;

namespace UnityExtended.Extensions
{
    public static class Transform2DExtension
    {
        /// <summary>
        /// Rotate the GameObject to the target coordinate
        /// </summary>
        /// <param name="trans">The object wich will be rotated</param>
        /// <param name="target">The place where the object will be rotated</param>
        [System.Obsolete("May not work in some situations")]
        public static void LookToPosition(this Transform trans,Vector3 target)
        {
            trans.rotation = Quaternion.LookRotation(trans.position - target, Vector3.forward);
            trans.eulerAngles = new Vector3(0, 0, trans.eulerAngles.z + 90.0f);
        }
    }
}
