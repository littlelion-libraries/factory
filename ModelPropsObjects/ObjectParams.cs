using System.Numerics;
using Factories.HashValues;

namespace Factories.ModelPropsObjects
{
    public struct ObjectParams
    {
        public string Hash;
        public HashValue<int>[] IntHashValues;
        public Vector3 Position;
        public HashValue<string>[] StringHashValues;
    }
}