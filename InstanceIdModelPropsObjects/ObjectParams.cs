using System.Numerics;

namespace Factories.InstanceIdModelPropsObjects
{
    public struct ObjectParams
    {
        public string Hash;
        public HashValue<int>[] IntHashValues;
        public Vector3 Position;
        public HashValue<string>[] StringHashValues;
    }
}