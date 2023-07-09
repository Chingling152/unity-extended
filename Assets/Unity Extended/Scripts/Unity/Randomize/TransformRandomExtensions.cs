using UnityEngine;

namespace UnityExtended.Unity.Randomize
{
    public static class TransformRandomExtensions
    {
        public static void RandomRotation(this Transform transform)
        {
            transform.Rotate(
                xAngle: Random.Range(0, 360),
                yAngle: Random.Range(0, 360),
                zAngle: Random.Range(0, 360)
            );
        }

        public static void RandomXRotation(this Transform transform)
        {
            transform.Rotate(Random.Range(0, 360), 0, 0);
        }

        public static void RandomYRotation(this Transform transform)
        {
            transform.Rotate(0, Random.Range(0, 360), 0);
        }

        public static void RandomZRotation(this Transform transform)
        {
            transform.Rotate(0, 0, Random.Range(0, 360));
        }
    }
}
