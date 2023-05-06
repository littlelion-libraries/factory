using System;
using System.Reflection;
using Factories.Decorators;

namespace Factories.DelegatePropertyDecorators
{
    public class DelegatePropertyDecorator<TObject, TParams, TProperty> : IDecorator<TObject, TParams>
    {
        private readonly object[] _args = new object[1];
        private MethodInfo _methodInfo;

        public string Property
        {
            set
            {
                var property = typeof(TObject).GetProperty(value) ?? throw new NullReferenceException(value);
                _methodInfo = property.SetMethod;
            }
        }

        public IFactory<PropertyFactoryMaterial<TObject, TParams>, TProperty> PropertyFactory { private get; set; }

        public void Decorate(TObject obj, TParams parameters)
        {
            _args[0] = PropertyFactory.Create(new PropertyFactoryMaterial<TObject, TParams>
            {
                Object = obj,
                Params = parameters
            });
            _methodInfo.Invoke(obj, _args);
        }
    }
}