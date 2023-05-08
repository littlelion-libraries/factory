using Factories.FactoryDecorators;

namespace Factories.PropertyDecorators
{
    public static class PropertyDecoratorUtility
    {
        public static PropertyDecorator<TObject, TParameter, TProperty> Create<TObject, TParameter, TProperty>(
            IFactory<PropertyFactoryMaterial<TObject, TParameter>, TProperty> propertyFactory
        ) where TObject : IPropertyObject<TProperty>
        {
            return new PropertyDecorator<TObject, TParameter, TProperty>
            {
                PropertyFactory = propertyFactory
            };
        }
    }
}