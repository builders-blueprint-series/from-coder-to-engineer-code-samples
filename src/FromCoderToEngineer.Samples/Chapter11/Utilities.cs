namespace FromCoderToEngineer.Samples.Chapter11
{
    using System;

    public static class Utilities
    {
        public static string GenerateCustomerId(this Guid id)
        {
            return id.ToString().Substring(0, 8);
        }
    }
}
