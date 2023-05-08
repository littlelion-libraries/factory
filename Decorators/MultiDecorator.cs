namespace Factories.Decorators
{
    public class MultiDecorator<TObject, TParams> : IDecorator<TObject, TParams>
    {
        public IDecorator<TObject, TParams>[] Decorators { private get; set; }

        public void Decorate(TObject obj, TParams param)
        {
            foreach (var decorator in Decorators)
            {
                decorator.Decorate(obj, param);
            }
        }
    }
}