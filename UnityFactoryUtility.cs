using System.Collections.Generic;
using UnityEngine;

namespace Factories
{
    public static class UnityFactoryUtility
    {
        public static UnityHashFactory<T> SelectFactory<T>(IEnumerable<T> elements) where T : Object
        {
            return new UnityHashFactory<T>
            {
                ObjectArray = elements
            };
        }
    }
}