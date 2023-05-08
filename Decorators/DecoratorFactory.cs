namespace Factories.Decorators
{
    public class DecoratorFactory<TMaterial, TProduct> : IFactory<TMaterial, TProduct>
    {
        public IDecorator<TProduct, TMaterial> Decorator { get; set; }
        public IFactory<TMaterial, TProduct> Impl { get; set; }

        public TProduct Create(TMaterial material)
        {
            var product = Impl.Create(material);
            Decorator.Decorate(product, material);
            return product;
        }
    }
}