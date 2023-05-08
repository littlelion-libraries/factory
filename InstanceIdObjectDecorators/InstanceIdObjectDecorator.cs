using CSharpBoosts;
using Factories.Decorators;
using Factories.InstanceIdObjectDecorators;

namespace Factories.InstanceIdDecorators
{
    public class InstanceIdObjectDecorator<TObject, TParams> : IDecorator<TObject, TParams>
        where TObject : IInstanceIdObject
    {
        public IFactory<Unit, int> InstanceIdFactory { private get; set; }

        public void Decorate(TObject obj, TParams param)
        {
            obj.InstanceId = InstanceIdFactory.Create(Unit.Instance);
        }
    }
}