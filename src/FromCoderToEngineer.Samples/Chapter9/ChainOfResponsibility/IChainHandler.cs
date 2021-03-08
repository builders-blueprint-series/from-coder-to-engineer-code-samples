namespace FromCoderToEngineer.Samples.Chapter9.ChainOfResponsibility
{
    using System.Threading.Tasks;

    public interface IChainHandler<T>
    {
        Task<T> Handle(T command);
    }
}
