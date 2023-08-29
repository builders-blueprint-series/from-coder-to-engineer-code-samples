using FromCoderToEngineer.Samples.Chapter3.Common;

namespace FromCoderToEngineer.Samples.Chapter3.ProblemWithNewKeyword
{
    public class CustomerService
    {
        public void CreateCustomer(CreateCustomerRequest request)
        {
            var customer = new Customer(request.Name);

            // Finish adding customer.
        }
    }
}