namespace Factories.InstanceIdModelPropsObjects
{
    public class InstanceIdModelPropsObjectFactory<TObject, TModel, TProps> : IParamsFactory<TObject, ObjectParams>
        where TObject : IInstanceIdModelPropsObject<TModel, TProps>, new()
    {
        public class Props
        {
            public InstanceId InstanceId;
            public IHashFactory<TModel> ModelFactory;
            public IParamsFactory<TProps, PropsObjectParams<TModel>> PropsFactory;
        }

        private Props _props;

        public TObject Create(ObjectParams parameters)
        {
            var model = _props.ModelFactory.Create(parameters.Hash);
            return new TObject
            {
                InstanceId = _props.InstanceId.Next(),
                Model = model,
                Props = _props.PropsFactory.Create(new PropsObjectParams<TModel>()
                {
                    IntHashValues = parameters.IntHashValues,
                    Model = model,
                    Position = parameters.Position,
                    StringHashValues = parameters.StringHashValues
                })
            };
        }
    }
}