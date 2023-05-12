using System;
using System.Collections.Generic;
using System.Linq;

namespace Factories
{
    public static class FactoryUtility
    {
        public struct Factory<TProduct, TMaterial>
        {
        }

        public static Factory<TProduct, TMaterial> Create<TProduct, TMaterial>()
        {
            return new Factory<TProduct, TMaterial>();
        }

        public static IFactory<TDesMaterial, TProduct> Select<TDesMaterial, TProduct, TSrcMaterial>(
            this Factory<TDesMaterial, TProduct> _,
            IFactory<TSrcMaterial, TProduct> factory,
            Func<TDesMaterial, TSrcMaterial> transform
        )
        {
            return new TransformFactory<TDesMaterial, TProduct, TSrcMaterial, TProduct>
            {
                Src = factory,
                Transform = transform
            };
        }

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

        public static DictionaryFactory<TKey, TMaterial, TProduct> ToDictionaryFactory<TKey, TMaterial, TProduct>(
            this IEnumerable<(TKey Key, IFactory<TMaterial, TProduct> Factory)> factories,
            Func<TMaterial, TKey> keySelector
        )
        {
            return new DictionaryFactory<TKey, TMaterial, TProduct>
            {
                Factories = factories.ToDictionary(it => it.Key, it => it.Factory),
                KeySelector = keySelector
            };
        }
    }
}