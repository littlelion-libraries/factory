using System;

namespace Factories.Decorators
{
    public class ObjectTransformDecorator<TDesObj, TParam, TSrcObj> : IDecorator<TDesObj, TParam>
    {
        public IDecorator<TSrcObj, TParam> Source { private get; set; }
        public Func<TDesObj, TSrcObj> Transform { private get; set; }

        public void Decorate(TDesObj obj, TParam param)
        {
            Source.Decorate(Transform(obj), param);
        }
    }
}