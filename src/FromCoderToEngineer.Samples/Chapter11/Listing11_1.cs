namespace FromCoderToEngineer.Samples.Chapter11
{
    using System;

    public class Customer
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public int LoyaltyPoints { get; set; }

        public int PointsYearToDate { get; set; }
    }
}
