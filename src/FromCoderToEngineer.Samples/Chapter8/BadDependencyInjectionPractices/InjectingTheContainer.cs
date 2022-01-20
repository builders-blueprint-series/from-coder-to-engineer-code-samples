using FromCoderToEngineer.Samples.Chapter8.DependencyInversion;
using System;

namespace FromCoderToEngineer.Samples.Chapter8.BadDependencyInjectionPractices
{
    public class InjectingTheContainer : ICustomerService
    {
        private readonly IServiceProvider _serviceProvider;

        public InjectingTheContainer(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void Handle(ChangeCustomerReservationTime request)
        {
            // Handle the request.
        }
    }
}