namespace FromCoderToEngineer.Samples.Chapter8.DependencyInversion
{
    using System;

    public class CustomerRepository : ICustomerRepository, IDisposable
    {
        private readonly CustomerContext _context;

        public CustomerRepository(CustomerContext context)
        {
            _context = context;
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
