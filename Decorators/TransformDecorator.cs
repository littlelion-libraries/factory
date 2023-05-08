using System;

namespace Factories.Decorators
{
    public class TransformDecorator<TDesObj, TDesParam, TSrcObj, TSrcParam> : IDecorator<TDesObj, TDesParam>
    {
        public Func<TDesObj, TSrcObj> ObjTransform { private get; set; }
        public Func<TDesParam, TSrcParam> ParamTransform { private get; set; }
        public IDecorator<TSrcObj, TSrcParam> Src { private get; set; }

        public void Decorate(TDesObj obj, TDesParam param)
        {
            Src.Decorate(ObjTransform(obj), ParamTransform(param));
        }
    }
}