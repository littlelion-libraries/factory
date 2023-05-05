namespace Factories.InstanceIdModelPropsObjects
{
    public interface IInstanceIdModelPropsObject<TModel, TProps> : IInstanceIdObject
    {
        public TModel Model { get; set; }
        public TProps Props { get; set; }
    }
}