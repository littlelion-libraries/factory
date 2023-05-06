using System;

namespace Factories
{
    public static class FactoryUtility
    {
        public static IFactory<TDesMaterial, TProduct> Select<TDesMaterial, TProduct, TSrcMaterial>(
            this IFactory<TSrcMaterial, TProduct> factory,
            Func<TDesMaterial, TSrcMaterial> transform
        )
        {
            return new TransformFactory<TDesMaterial, TProduct, TSrcMaterial, TProduct>
            {
                Src = factory,
                Transform = transform
            };
        }
    }
}