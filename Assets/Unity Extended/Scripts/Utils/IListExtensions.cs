using System.Collections.Generic;
using UnityEngine;

namespace UnityExtended.Extensions
{
    public static class IListExtensions
    { 
        /// <summary>
        /// Returns a default value of a list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static T GetRandom<T>(this IList<T> list)
        {
            if(list == null)return default;
            return list[Random.Range(0,list.Count)];
        }

        public static T GetRandomInRange<T>(this IList<T> list,int min, int max)
        {
            if(min <= 0 && max <= 0 ) throw new System.InvalidOperationException("The min|max params must be absolute integers");
            if(min >= max) throw new System.InvalidOperationException("The min param must be smaller than max param");
            if(min > list.Count) throw new System.InvalidOperationException("The min param cannot be greater than list size");
            if(max > list.Count) throw new System.InvalidOperationException("The max param cannot be greater than list size");

            T[] newL = new T[max - min];

            for(int i = min; i < max; i++)
            {
                newL[i] = list[i];
            }

            return newL.GetRandom<T>();
        }
    } 
}