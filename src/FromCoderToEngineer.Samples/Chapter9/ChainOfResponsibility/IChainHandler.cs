using System.Threading.Tasks;

namespace FromCoderToEngineer.Samples.Chapter9.ChainOfResponsibility
{
    public interface IChainHandler<T>
    {
        Task<T> Handle(T command);
    }
}