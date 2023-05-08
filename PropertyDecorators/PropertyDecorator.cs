using Factories.Decorators;
using Factories.FactoryDecorators;

namespace Factories.PropertyDecorators
{
    public class PropertyDecorator<TObject, TParameter, TProperty> : IDecorator<TObject, TParameter>
        where TObject : IPropertyObject<TProperty>
    {
        public IFactory<PropertyFactoryMaterial<TObject, TParameter>, TProperty> PropertyFactory { private get; set; }

        public void Decorate(TObject obj, TParameter param)
        {
            obj.Property = PropertyFactory.Create(new PropertyFactoryMaterial<TObject, TParameter>
            {
                Object = obj,
                Parameter = param
            });
        }
    }
}