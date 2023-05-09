using System;

namespace Factories.Decorators
{
    public static class DecoratorUtility
    {
        public struct Decorator<TObject, TParameter>
        {
        }
        
        public static Decorator<TProduct, TMaterial> Create<TProduct, TMaterial>()
        {
            return new Decorator<TProduct, TMaterial>();
        }
        
        public static TransformDecorator<TDesObj, TParam, TSrcObj, TParam> Select<TDesObj, TParam, TSrcObj>(
            this Decorator<TDesObj, TParam> _,
            IDecorator<TSrcObj, TParam> decorator,
            Func<TDesObj, TSrcObj> objTrans
        )
        {
            return new TransformDecorator<TDesObj, TParam, TSrcObj, TParam>
            {
                ObjTransform = objTrans,
                ParamTransform = param => param,
                // Src = decorator
            };
        }
        
        // public static IDecorator<TDesObj, TDesParam> Select<TDesObj, TDesParam, TSrcObj, TSrcParam>(
        //     this IDecorator<TSrcObj, TSrcParam> decorator,
        //     Func<TDesObj, TSrcObj> objTrans,
        //     Func<TDesParam, TSrcParam> paramTrans
        // )
        // {
        //     return new TransformDecorator<TDesObj, TDesParam, TSrcObj, TSrcParam>
        //     {
        //         ObjTransform = objTrans,
        //         ParamTransform = paramTrans,
        //         Src = decorator
        //     };
        // }
    }
}