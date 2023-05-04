namespace Factories
{
    public class InstanceIdParamsFactory<T, TParams> : IParamsFactory<T, TParams> where T : IInstanceIdObject
    {
        public int InstanceId { get; set; }
        public IParamsFactory<T, TParams> Impl { get; set; }

        public T Create(TParams parameters)
        {
            var obj = Impl.Create(parameters);
            obj.InstanceId = InstanceId++;
            return obj;
        }
    }
}