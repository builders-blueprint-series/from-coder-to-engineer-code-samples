namespace FromCoderToEngineer.Samples.Chapter8.DealingWithConcreteOnlyClasses
{
    using System;
    using FromCoderToEngineer.Samples.Chapter8.DependencyInversion;

    public class ServiceThatUsesDateTime : ICustomerService
    {
        public void Handle(ChangeCustomerReservationTime request)
        {
            if (request.DateTime < DateTime.Now)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
