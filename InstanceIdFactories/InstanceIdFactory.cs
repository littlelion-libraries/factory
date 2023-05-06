using CSharpBoosts;

namespace Factories.InstanceIdFactory
{
    public class InstanceIdFactory : IFactory<Unit, int>
    {
        public int Value { private get; set; }

        public int Create(Unit material)
        {
            return Value++;
        }
    }
}