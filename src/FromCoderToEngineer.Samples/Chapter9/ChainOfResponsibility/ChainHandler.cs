namespace FromCoderToEngineer.Samples.Chapter9.ChainOfResponsibility
{
    using System;
    using System.Threading.Tasks;

    public abstract class ChainHandler<T> : IChainHandler<T>
    {
        private readonly IChainHandler<T> _successor;

        protected ChainHandler(IChainHandler<T> successor)
        {
            _successor = successor;
        }

        public async Task<T> Handle(T request)
        {
            Func<int, int> bleh = x => x;

            var result = await DoWork(request);

            return _successor == null ? result : await _successor.Handle(result);
        }

        protected abstract Task<T> DoWork(T request);
    }
}
