namespace FromCoderToEngineer.Samples.Chapter8.BadDependencyInjectionPractices
{
    using DependencyInversion;

    public class DisposingFromTheContainer : ICustomerService
    {
        public void Handle(ChangeCustomerReservationTime request)
        {
            using (var repository = new CustomerRepository(new CustomerContext()))
            {
                // Do something with your repository.
            }
        }
    }
}
