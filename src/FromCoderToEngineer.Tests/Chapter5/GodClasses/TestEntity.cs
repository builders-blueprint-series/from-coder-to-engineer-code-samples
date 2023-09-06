using FromCoderToEngineer.Samples.Chapter5.GodClasses;

namespace FromCoderToEngineer.Tests.Chapter5.GodClasses
{
    public class TestEntity : Entity
    {
        public void AddNullNotification()
        {
            AddNotification(null);
        }

        public void AddNotification()
        {
            AddNotification(new ReservationCreated());
        }
    }
}
