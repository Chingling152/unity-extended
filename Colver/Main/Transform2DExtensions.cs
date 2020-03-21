using UnityEngine;

namespace Colver.Main
{
    public static class Transform2DExtension
    {
        public static void LookToPosition(this Transform trans,Vector3 target)
        {
            trans.rotation = Quaternion.LookRotation(trans.position - target, Vector3.forward);
            trans.eulerAngles = new Vector3(0, 0, trans.eulerAngles.z + 90.0f);
        }
    }
}
