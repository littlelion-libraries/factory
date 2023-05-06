namespace Factories.Decorators
{
    public class DecoratorFactory<TMaterial, TProduct> : IFactory<TMaterial, TProduct>
    {
        public IDecorator<TMaterial, TProduct> Decorator { get; set; }
        public IFactory<TMaterial, TProduct> Impl { get; set; }

        public TProduct Create(TMaterial material)
        {
            var product = Impl.Create(material);
            Decorator.Decorate(material, product);
            return product;
        }
    }
}