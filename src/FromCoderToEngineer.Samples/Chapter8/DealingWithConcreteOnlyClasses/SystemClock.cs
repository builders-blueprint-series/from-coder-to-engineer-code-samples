using System;

namespace FromCoderToEngineer.Samples.Chapter8.DealingWithConcreteOnlyClasses
{
    public class SystemClock : ISystemClock
    {
        public DateTime Now()
        {
            return DateTime.Now;
        }
    }
}
