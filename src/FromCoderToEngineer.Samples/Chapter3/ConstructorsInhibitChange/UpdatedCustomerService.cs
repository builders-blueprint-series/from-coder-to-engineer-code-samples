using FromCoderToEngineer.Samples.Chapter3.Common;

namespace FromCoderToEngineer.Samples.Chapter3.ConstructorsInhibitChange
{
    public class UpdatedCustomerService
    {
        public void UpdatedCreateCustomer(CreateCustomerRequest request)
        {
            var customer = new UpdatedCustomer(request.Name, request.PreferredSeating);

            // Finish adding customer.
        }
    }
}
