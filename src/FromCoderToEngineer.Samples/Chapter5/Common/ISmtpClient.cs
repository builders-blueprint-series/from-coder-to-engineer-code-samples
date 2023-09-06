namespace FromCoderToEngineer.Samples.Chapter5.Common
{
    public interface ISmtpClient
    {
        void SendEmail(string client, string title, string body);
    }
}
