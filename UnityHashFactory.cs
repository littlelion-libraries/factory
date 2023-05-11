using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Factories
{
    public class UnityHashFactory<T> : IHashFactory<T> where T : Object
    {
        private Dictionary<string, T> _objects = new();

        public IEnumerable<T> ObjectArray
        {
            set => _objects = value.ToDictionary(it => it.name);
        }

        public Dictionary<string, T> Objects
        {
            set => _objects = value;
        }

        public T Create(string material)
        {
            return Object.Instantiate(_objects[material]);
        }
    }
}