using System;

namespace Factories
{
    public class TransformFactory<TDes, TDesParams, TSrc, TSrcParams> : IParamsFactory<TDes, TDesParams>
        where TSrc : TDes
    {
        public IParamsFactory<TSrc, TSrcParams> Src { get; set; }
        public Func<TDesParams, TSrcParams> Transform { get; set; }

        public TDes Create(TDesParams parameters)
        {
            return Src.Create(Transform(parameters));
        }
    }
}