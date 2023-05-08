using System;
using System.Reflection;
using Factories.Decorators;
using Factories.PropertyDecorators;

namespace Factories.DelegatePropertyDecorators
{
    public class DelegatePropertyDecorator<TObject, TParameter, TProperty> : IDecorator<TObject, TParameter>
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

        public IFactory<PropertyFactoryMaterial<TObject, TParameter>, TProperty> PropertyFactory { private get; set; }

        public void Decorate(TObject obj, TParameter param)
        {
            _args[0] = PropertyFactory.Create(new PropertyFactoryMaterial<TObject, TParameter>
            {
                Object = obj,
                Parameter = param
            });
            _methodInfo.Invoke(obj, _args);
        }
    }
}