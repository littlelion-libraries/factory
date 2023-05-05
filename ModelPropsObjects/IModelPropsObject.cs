namespace Factories.ModelPropsObjects
{
    public interface IModelPropsObject<TModel, TProps>
    {
        public TModel Model { get; set; }
        public TProps Props { get; set; }
    }
}