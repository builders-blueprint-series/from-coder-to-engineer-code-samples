namespace FromCoderToEngineer.Samples.Chapter8.BadDependencyInjectionPractices
{
    using System;
    using DependencyInversion;

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
