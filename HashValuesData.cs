using Factories.HashValues;

namespace Factories
{
    public struct HashValuesData
    {
        public string Hash;
        public HashValue<int>[] Ints;
        public HashValue<string>[] Strings;
    }
}