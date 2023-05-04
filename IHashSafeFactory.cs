namespace Factories
{
    public interface IHashSafeFactory<T>
    {
        bool TryCreate(string hash, out T value);
    }
}