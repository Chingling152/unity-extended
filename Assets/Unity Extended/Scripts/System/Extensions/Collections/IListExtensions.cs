﻿using System;
using System.Collections.Generic;

namespace UnityExtended.System.Extensions.Collections.Generic
{
    public static class IListExtensions
    {
        /// <summary>
        /// Returns a default value of a list
        /// </summary>
        /// <typeparam name="T">The type of the current List/Array</typeparam>
        /// <returns>Returns a random item from <paramref name="list"/></returns>
        public static T GetRandom<T>(this IList<T> list)
        {
            if(list == null)
                return default;

            var randomIndex = new Random().Next(0, list.Count);
            return list[randomIndex];
        }

        /// <summary>
        /// Return a random Item from an array/List
        /// </summary>
        /// <typeparam name="T">The type of the current List/Array</typeparam>
        /// <param name="min">The min value in the list wich will be searched</param>
        /// <param name="max">The min value in the list wich will be searched</param>
        /// <returns>Returns a random item from <paramref name="list"/> between <paramref name="min"/> and <paramref name="max"/> </returns>
        public static T GetRandomInRange<T>(this IList<T> list,int min, int max)
        {
            if(min <= 0 && max <= 0 ) 
                throw new InvalidOperationException("The min|max params must be absolute integers");
            if(min >= max) 
                throw new InvalidOperationException("The min param must be smaller than max param");
            if(min > list.Count) 
                throw new InvalidOperationException("The min param cannot be greater than list size");
            if(max > list.Count) 
                throw new InvalidOperationException("The max param cannot be greater than list size");

            T[] newL = new T[max - min];

            for(int i = min; i < max; i++)
            {
                newL[i] = list[i];
            }

            return newL.GetRandom();
        }
    } 
}