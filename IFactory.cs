namespace Factories
{
    public interface IFactory<in TMaterial, out TProduct>
    {
        TProduct Create(TMaterial material);
    }
}