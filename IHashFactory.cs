namespace Factories
{
    public interface IHashFactory<out TProduct> : IFactory<string, TProduct>
    {
    }
}