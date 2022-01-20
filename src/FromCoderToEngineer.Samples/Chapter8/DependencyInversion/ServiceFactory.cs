using Microsoft.Extensions.DependencyInjection;
using System;

namespace FromCoderToEngineer.Samples.Chapter8.DependencyInversion
{
    public static class ServiceFactory
    {
        public static ICustomerService CustomerService()
        {
            return new CustomerService(new CustomerRepository(new CustomerContext()), new CustomerFactory());
        }

        public static IServiceProvider ServiceProvider()
        {
            var collection = new ServiceCollection();

            return collection.BuildServiceProvider();
        }
    }
}