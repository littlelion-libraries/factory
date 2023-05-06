using Factories.Decorators;

namespace Factories.FactoryDecorators
{
    public class PropertyDecorator<TMaterial, TProperty, TProduct> : IDecorator<TProduct, TMaterial>
        where TProduct : IPropertyObject<TProperty>
    {
        public IFactory<TMaterial, TProperty> PropertyFactory { private get; set; }

        public void Decorate(TProduct obj, TMaterial parameters)
        {
            obj.Property = PropertyFactory.Create(parameters);
        }
    }
}