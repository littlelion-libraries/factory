namespace Factories.FactoryDecorators
{
    public interface IPropertyObject<in TProperty>
    {
        TProperty Property { set; }
    }
}