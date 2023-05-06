using CSharpBoosts;
using Factories.Decorators;
using Factories.InstanceIdObjectDecorators;

namespace Factories.InstanceIdDecorators
{
    public class InstanceIdObjectDecorator<TObject, TParams> : IDecorator<TObject, TParams>
        where TObject : IInstanceIdObject
    {
        public IFactory<Unit, int> InstanceIdFactory { private get; set; }

        public void Decorate(TObject obj, TParams parameters)
        {
            obj.InstanceId = InstanceIdFactory.Create(Unit.Instance);
        }
    }
}