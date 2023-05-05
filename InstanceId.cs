namespace Factories
{
    public class InstanceId
    {
        private int _instanceId;

        public InstanceId(int instanceId)
        {
            _instanceId = instanceId;
        }

        public int Next()
        {
            return _instanceId++;
        }
    }
}