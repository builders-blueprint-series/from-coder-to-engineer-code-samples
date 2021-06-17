namespace FromCoderToEngineer.Samples.Chapter8.DependencyInversion
{
    using Microsoft.Extensions.DependencyInjection;

    public class CustomerModule
    {
        public void Register(IServiceCollection collection)
        {
            collection.AddDbContext<CustomerContext>();
            collection.AddTransient<CustomerFactory>();
            collection.AddTransient<ICustomerRepository, CustomerRepository>();
            collection.AddTransient<ICustomerService, CustomerService>();
        }
    }
}
