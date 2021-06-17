namespace FromCoderToEngineer.Samples.Chapter8.BadDependencyInjectionPractices
{
    public class RegisteredAsSingleton
    {
        private readonly RegisteredAsTransient _transient;

        public RegisteredAsSingleton(RegisteredAsTransient transient)
        {
            _transient = transient;
        }
    }
}
