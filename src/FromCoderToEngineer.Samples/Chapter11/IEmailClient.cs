namespace FromCoderToEngineer.Samples.Chapter11
{
    public interface IEmailClient
    {
        void SendNewStatusEmail(Customer customer);

        void SendApology(Customer customer);
    }
}