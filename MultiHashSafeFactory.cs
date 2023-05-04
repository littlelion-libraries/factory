namespace Factories
{
    public class MultiHashSafeFactory<T> : IHashSafeFactory<T> where T : class
    {
        private IHashSafeFactory<T>[] _factories;

        public IHashSafeFactory<T>[] Factories
        {
            set => _factories = value;
        }

        public bool TryCreate(string parameters, out T value)
        {
            foreach (var it in _factories)
            {
                if (it.TryCreate(parameters, out value))
                {
                    return true;
                }
            }

            value = default;
            return false;
        }
    }
}