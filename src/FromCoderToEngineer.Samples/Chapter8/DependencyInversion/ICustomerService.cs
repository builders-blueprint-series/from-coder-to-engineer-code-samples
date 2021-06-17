namespace FromCoderToEngineer.Samples.Chapter8.DependencyInversion
{
    public interface ICustomerService
    {
        void Handle(ChangeCustomerReservationTime request);
    }
}
