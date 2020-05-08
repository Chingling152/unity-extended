using UnityEngine;

namespace UnityExtended.Extensions
{
    public static class SpriteRendererExtension
    {
        /// <summary>
        /// Sets a random color to a specific Sprite
        /// </summary>
        /// <param name="spr">Sprite wich will have the color changed</param>
        public static void RandomColor(this SpriteRenderer spr)
        {
            Color color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
            spr.material.color = color;
        }
    }
}
