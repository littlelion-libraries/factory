using System;

namespace Factories.Decorators
{
    public static class DecoratorUtility
    {
        public static IDecorator<TDesObj, TDesParam> Select<TDesObj, TDesParam, TSrcObj, TSrcParam>(
            this IDecorator<TSrcObj, TSrcParam> decorator,
            Func<TDesObj, TSrcObj> objTrans,
            Func<TDesParam, TSrcParam> paramTrans
        )
        {
            return new TransformDecorator<TDesObj, TDesParam, TSrcObj, TSrcParam>
            {
                ObjTransform = objTrans,
                ParamTransform = paramTrans,
                Src = decorator
            };
        }
    }
}