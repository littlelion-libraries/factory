using System;
using System.Collections.Generic;

namespace Factories
{
    public class DictionaryFactory<TKey, TMaterial, TProduct> : IFactory<TMaterial, TProduct>
    {
        public IDictionary<TKey, IFactory<TMaterial, TProduct>> Factories { private get; set; }
        public Func<TMaterial, TKey> KeySelector { private get; set; }

        public TProduct Create(TMaterial material)
        {
            return Factories[KeySelector(material)].Create(material);
        }
    }
}