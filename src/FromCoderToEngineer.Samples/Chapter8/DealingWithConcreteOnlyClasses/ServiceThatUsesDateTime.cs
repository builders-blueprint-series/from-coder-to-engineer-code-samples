using FromCoderToEngineer.Samples.Chapter8.DependencyInversion;
using System;

namespace FromCoderToEngineer.Samples.Chapter8.DealingWithConcreteOnlyClasses
{
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