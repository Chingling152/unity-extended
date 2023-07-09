using UnityEngine;

namespace UnityExtended.Unity._2D.Randomize
{
    public static class SpriteRendererRandomExtension
    {
        /// <summary>
        /// Sets a random color to a specific Sprite
        /// </summary>
        /// <param name="spr">Sprite wich will have the color changed</param>
        public static void RandomColor(this SpriteRenderer spr)
        {
            spr.material.color = new Color(
                r: Random.Range(0.0f, 1.0f), 
                g: Random.Range(0.0f, 1.0f), 
                b: Random.Range(0.0f, 1.0f)
           );
        }

        public static void RandomAlpha(this SpriteRenderer spr)
        {
            var color = spr.material.color;
            spr.material.color = new Color(
                r: color.r,
                g: color.g,
                b: color.b,
                a: Random.Range(0.0f, 1.0f)
            );
        }
    }
}
