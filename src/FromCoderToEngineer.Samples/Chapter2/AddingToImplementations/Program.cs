namespace FromCoderToEngineer.Samples.Chapter2.AddingToImplementations
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var superUser = new EliteCustomer();

            var discount = superUser.ApplyDiscount(55.40m);
        }
    }
}
