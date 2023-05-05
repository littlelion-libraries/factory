using System.Numerics;

namespace Factories.InstanceIdModelPropsObjects
{
    public struct PropsObjectParams<TModel>
    {
        public TModel Model;
        public HashValue<int>[] IntHashValues;
        public Vector3 Position;
        public HashValue<string>[] StringHashValues;
    }
}