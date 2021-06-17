namespace FromCoderToEngineer.Samples.Chapter8.DependencyInversion
{
    using System;
    using Microsoft.Extensions.DependencyInjection;

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