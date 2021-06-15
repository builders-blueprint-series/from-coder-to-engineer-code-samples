namespace FromCoderToEngineer.Samples.Chapter8
{
    using FromCoderToEngineer.Samples.Chapter9.GenrricDelegates;

    public interface IHandleRequest<in TRequest, out TResponse>
    {
        public TResponse Handle(TRequest request);
    }

    public interface IHandleRequest<in TRequest> : IHandleRequest<TRequest, Unit>
    {
    }
}
