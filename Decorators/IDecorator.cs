namespace Factories.Decorators
{
    public interface IDecorator<in TObject, in TParams>
    {
        void Decorate(TObject obj, TParams parameters);
    }
}