using System;
using System.Collections.Generic;
using System.Linq;
using Object = UnityEngine.Object;

namespace Factories
{
    public class UnityHashFactory<T> : IHashFactory<T>
    {
        private Dictionary<string, Object> _objects = new();

        public IEnumerable<Object> ObjectArray
        {
            set => _objects = value.ToDictionary(it => it.name);
        }

        public Dictionary<string, Object> Objects
        {
            set => _objects = value;
        }

        public T Create(string material)
        {
            return Object.Instantiate(_objects[material]) is T t ? t : throw new InvalidCastException();
        }
    }
}