using UnityEngine;

namespace UnityExtended.Unity.Utils
{
    /// <summary>
    /// Static class to handle GameObjects in Scene
    /// </summary>
    public static class GameObjectUtils
    {
        /// <summary>
        /// Gets the current count of every GameObject of type in scene
        /// </summary>
        /// <typeparam name="T">Type of the GameObjects</typeparam>
        /// <param name="disabled">Define if will search disabled GameObjects</param>
        /// <returns>returns the count of every object of a type in scene</returns>
        public static int InstanceCount<T>(bool disabled = false) where T : MonoBehaviour
        {
            T[] instances = GameObject.FindObjectsOfType<T>();
            if (disabled)
                return instances.Length;

            var count = 0;
            foreach (var instance in instances)
                count = instance.isActiveAndEnabled ? count + 1 : count;

            return count;
        }

        /// <summary>
        /// Gets the current count of every GameObject of tag in scene
        /// </summary>
        /// <param name="tag">Tag of the gameobjects</param>
        /// <param name="disabled">Define if will search disabled GameObjects</param>
        /// <returns>returns the count of every object of a tag in scene</returns>
        public static int InstanceCount(string tag, bool disabled = false)
        {
            if(tag == null) throw new System.ArgumentNullException("Tag cannot be null");

            GameObject[] instances = GameObject.FindGameObjectsWithTag(tag);
            if (disabled)
                return instances.Length;

            var count = 0;
            foreach (var instance in instances)
                count = instance.activeInHierarchy ? count + 1 : count;

            return count;
        }
    }
}
