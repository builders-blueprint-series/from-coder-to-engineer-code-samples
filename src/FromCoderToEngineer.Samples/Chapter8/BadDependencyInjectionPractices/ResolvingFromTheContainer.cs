namespace FromCoderToEngineer.Samples.Chapter8.BadDependencyInjectionPractices
{
    using System;
    using DependencyInversion;
    using Microsoft.Extensions.DependencyInjection;

    public class ResolvingFromTheContainer : ICustomerService
    {
        private readonly IServiceProvider _serviceProvider;

        public ResolvingFromTheContainer(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void Handle(ChangeCustomerReservationTime request)
        {
            var repository = _serviceProvider.GetService<ICustomerRepository>();

            // Handle the request.
        }
    }
}
