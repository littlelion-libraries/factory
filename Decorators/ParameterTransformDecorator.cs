using System;

namespace Factories.Decorators
{
    public class ParameterTransformDecorator<TDesParam, TObj, TSrcParam> : IDecorator<TObj, TDesParam>
    {
        public IDecorator<TObj, TSrcParam> Source { private get; set; }
        public Func<TDesParam, TSrcParam> Transform { private get; set; }

        public void Decorate(TObj obj, TDesParam param)
        {
            Source.Decorate(obj, Transform(param));
        }
    }
}