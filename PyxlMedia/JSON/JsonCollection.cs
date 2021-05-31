using System;
using System.Collections.Generic;
using UnityEngine;

namespace PyxlMedia.JSON
{
    /// <summary>
    /// A tool that helps Unity parse JSON arrays.
    /// </summary>
    public static class JsonCollection
    {
        [Serializable]
        private class Wrapper<T>
        {
            public T[] data;
        }
            
        /// <summary>
        /// Converts an JSON array into a collection.
        /// </summary>
        /// <param name="json">The raw JSON string containing the data array.</param>
        /// <typeparam name="T">The model the JSON data is being converted to. Must be Serializable.</typeparam>
        /// <returns>A collection of T</returns>
        public static IEnumerable<T> FromJson<T>(string json)
        {
            json = $"{{\"data\":{json}}}";
            var wrapper = JsonUtility.FromJson<Wrapper<T>>(json);
            return wrapper.data;
        }
    }
}

