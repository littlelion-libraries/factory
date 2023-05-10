using System;
using Factories.FactoryDecorators;
using Factories.PropertyDecorators;

namespace Factories.Decorators
{
    public static class DecoratorUtility
    {
        
        // public static Decorator<TProduct, TMaterial> Create<TProduct, TMaterial>()
        // {
        //     return new Decorator<TProduct, TMaterial>();
        // }
        //
        // public static TransformDecorator<TDesObj, TParam, TSrcObj, TParam> Select<TDesObj, TParam, TSrcObj>(
        //     this Decorator<TDesObj, TParam> _,
        //     IDecorator<TSrcObj, TParam> decorator,
        //     Func<TDesObj, TSrcObj> objTrans
        // )
        // {
        //     return new TransformDecorator<TDesObj, TParam, TSrcObj, TParam>
        //     {
        //         ObjTransform = objTrans,
        //         ParamTransform = param => param,
        //         // Src = decorator
        //     };
        // }
        public static ObjectTransformDecorator<TDesObj, TParam, TSrcObj> SelectObject<TDesObj, TParam, TSrcObj>(
            this IDecorator<TSrcObj, TParam> decorator,
            Func<TDesObj, TSrcObj> transform
                )
        {
            return new ObjectTransformDecorator<TDesObj, TParam, TSrcObj>
            {
                Source = decorator,
                Transform = transform
            };
        }

        public static PropertyDecorator<TObject, TParameter, TProperty> SelectPropertyDecorator<TMaterial, TObject,
            TParameter, TProperty>(
            this IFactory<TMaterial, TProperty> factory,
            Func<TObject, TParameter, TMaterial> transform
        ) where TObject : IPropertyObject<TProperty>
        {
            return factory.SelectPropertyDecorator(
                new Func<PropertyFactoryMaterial<TObject, TParameter>, TMaterial>(material =>
                    transform(material.Object, material.Parameter)));
        }

        public static PropertyDecorator<TObject, TParameter, TProperty> SelectPropertyDecorator<TMaterial, TObject,
            TParameter, TProperty>(
            this IFactory<TMaterial, TProperty> factory,
            Func<PropertyFactoryMaterial<TObject, TParameter>, TMaterial> transform
        ) where TObject : IPropertyObject<TProperty>
        {
            return new PropertyDecorator<TObject, TParameter, TProperty>
            {
                PropertyFactory = FactoryUtility.Create<PropertyFactoryMaterial<TObject, TParameter>, TProperty>()
                    .Select(factory, transform)
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