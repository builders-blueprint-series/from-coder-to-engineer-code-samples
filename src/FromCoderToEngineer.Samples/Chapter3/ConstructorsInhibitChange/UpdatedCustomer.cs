using FromCoderToEngineer.Samples.Chapter3.Common;

namespace FromCoderToEngineer.Samples.Chapter3.ProblemWithNewKeyword
{
    public class UpdatedCustomer
    {
        public UpdatedCustomer(string name, PreferredSeating preferredSeating)
        {
            Name = name;
            PreferredSeating = preferredSeating;
        }

        public string Name { get; }

        public PreferredSeating PreferredSeating { get; }
    }
}
