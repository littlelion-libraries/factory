using System.Numerics;
using Factories.HashValues;

namespace Factories.ModelPropsObjects
{
    public struct PropsObjectParams<TModel>
    {
        public TModel Model;
        public HashValue<int>[] IntHashValues;
        public Vector3 Position;
        public HashValue<string>[] StringHashValues;
    }
}