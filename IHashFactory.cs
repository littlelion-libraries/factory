namespace Factories
{
    public interface IHashFactory<out T> : IParamsFactory<T, string>
    {
    }
}