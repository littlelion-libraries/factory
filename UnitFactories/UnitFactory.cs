using CSharpBoosts;

namespace Factories.UnitFactories
{
    public class UnitFactory<TProduct> : IFactory<Unit, TProduct> where TProduct : new()
    {
        public TProduct Create(Unit material)
        {
            return new TProduct();
        }
    }
}