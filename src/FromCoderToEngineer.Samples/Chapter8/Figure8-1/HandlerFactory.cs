namespace FromCoderToEngineer.Samples.Chapter8
{
    public static class HandlerFactory
    {
        public static IHandleRequest<ChangeCustomerReservationTime> ChangeCustomerReservationTimeHandler()
        {
            return new ChangeCustomerReservationTimeHandler(new CustomerRepository(new CustomerContext()), new CustomerFactory());
        }
    }
}