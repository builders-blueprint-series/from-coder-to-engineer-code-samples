using Microsoft.EntityFrameworkCore;

namespace FromCoderToEngineer.Samples.Before
{
    public sealed class ReservationContext : DbContext
    {
        public ReservationContext()
        {
            Database.EnsureCreated();
        }
    }
}
