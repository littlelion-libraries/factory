namespace Factories.Decorators
{
    public interface IDecorator<in TObject, in TParam>
    {
        void Decorate(TObject obj, TParam param);
    }
}