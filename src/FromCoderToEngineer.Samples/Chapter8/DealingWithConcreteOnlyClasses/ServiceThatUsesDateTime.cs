namespace FromCoderToEngineer.Samples.Chapter8.DealingWithConcreteOnlyClasses
{
    using System;
    using DependencyInversion;

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
