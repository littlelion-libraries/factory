namespace Factories
{
    public interface IParamsFactory<out T, in TParams>
    {
        T Create(TParams parameters);
    }
}