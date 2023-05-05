using System;
using System.Collections.Generic;
using Object = UnityEngine.Object;

namespace Factories
{
    public class UnityHashFactory<T> : IHashFactory<T>
    {
        private Dictionary<string, Object> _objects = new();

        public Dictionary<string, Object> Objects
        {
            set => _objects = value;
        }

        public T Create(string parameters)
        {
            return Object.Instantiate(_objects[parameters]) is T t ? t : throw new InvalidCastException();
        }
    }
}