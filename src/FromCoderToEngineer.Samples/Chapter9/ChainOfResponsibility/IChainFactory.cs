namespace FromCoderToEngineer.Samples.Chapter9.ChainOfResponsibility
{
    public interface IChainFactory<T>
    {
        IChainHandler<T> CreateChain();
    }
}
