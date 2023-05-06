using System;

namespace Factories
{
    public class TransformFactory<TDesMaterial, TDesProduct, TSrcMaterial, TSrcProduct> :
        IFactory<TDesMaterial, TDesProduct> where TSrcProduct : TDesProduct
    {
        public IFactory<TSrcMaterial, TSrcProduct> Src { private get; set; }
        public Func<TDesMaterial, TSrcMaterial> Transform { private get; set; }

        public TDesProduct Create(TDesMaterial material)
        {
            return Src.Create(Transform(material));
        }
    }
}