namespace FromCoderToEngineer.Samples.Chapter8.DealingWithConcreteOnlyClasses
{
    using System;

    public class SystemClock : ISystemClock
    {
        public DateTime Now()
        {
            return DateTime.Now;
        }
    }
}