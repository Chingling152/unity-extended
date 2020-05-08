using System.Collections.Generic;
using UnityEngine;

namespace UnityExtended.Extensions
{
    public static class GameObjectExtensions
    {
        /// <summary>
        /// Finde the closest gameobject of the current one based on it's tag
        /// </summary>
        /// <typeparam name="T">Type of object to find</typeparam>
        /// <param name="obj">Object wich is searching</param>
        /// <param name="tag">Tag of the searched object</param>
        /// <param name="maxDistance">Max distance that will be searched</param>
        /// <returns>Returns a single GameObject or null</returns>
        public static T FindNearestByTag<T>(this GameObject obj, string tag, float maxDistance = float.PositiveInfinity) where T : MonoBehaviour
        {
            var objects = GameObject.FindGameObjectsWithTag(tag);

            if (objects != null)
            {
                List<T> selectedObjects = new List<T>();
                foreach (var item in objects)
                {
                    if (item.TryGetComponent<T>(out var component))
                        selectedObjects.Add(component);
                }
                return FindNearests<T>(obj,selectedObjects, maxDistance);
            }
            return null;
        }

        /// <summary>
        /// Finde the closest gameobject of the current one based on it's Type
        /// </summary>
        /// <typeparam name="T">Type of object to find</typeparam>
        /// <param name="obj">Object wich is searching</param>
        /// <param name="maxDistance">Max distance that will be searched</param>
        /// <returns>Returns a single GameObject or null</returns>
        public static T FindNearestByType<T>(this GameObject obj,float maxDistance = float.PositiveInfinity) where T : MonoBehaviour
        {
            var objects = GameObject.FindObjectsOfType<T>();
            if (objects != null)
            {
                List<T> selectedObjects = new List<T>();
                foreach (var item in objects)
                {
                    if (item.TryGetComponent<T>(out var component))
                        selectedObjects.Add(component);
                }
                return FindNearests<T>(obj, selectedObjects, maxDistance);
            }
            return null;
        }

        /// <summary>
        /// Searchs on a list of GameObjects wich one it's closest to <see cref="obj"/>
        /// </summary>
        /// <typeparam name="T">Type of object to find</typeparam>
        /// <param name="obj">Object wich is searching</param>
        /// <param name="objects">Object list to be filtered</param>
        /// <param name="maxDistance">Max distance that will be searched</param>
        /// <returns>Returns the closests GameObject of obj or null</returns>
        public static T FindNearests<T>(this GameObject obj, List<T> objects, float maxDistance = float.PositiveInfinity) where T : MonoBehaviour
        {
            if (objects.Count == 0)
                return null;

            T nearestObject = null;
            foreach (T item in objects)
            {
                var dist = Vector3.Distance(obj.transform.position, item.transform.position);

                if (dist <= maxDistance)
                {
                    if (nearestObject == null)
                    {
                        nearestObject = item;
                    }
                    else
                    {
                        var dist2 = Vector3.Distance(obj.transform.position, nearestObject.transform.position);
                        nearestObject = dist < dist2 ? item : nearestObject;
                    }
                }
            }
            return nearestObject;
        }

        /// <summary>
        /// Finds a child insides the gameobject that match with the name parameter
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="name">The name of the child you want to search</param>
        /// <returns>returns a game object or null</returns>
        public static GameObject GetChildByName(this GameObject obj,string name)
        {
            var childCount = obj.transform.childCount;
            for(int i = 0; i < childCount; i++)
            {
                var child = obj.transform.GetChild(i).gameObject;
                if(child.name == name) return child;
            }
            return null;
        }
    }
}
