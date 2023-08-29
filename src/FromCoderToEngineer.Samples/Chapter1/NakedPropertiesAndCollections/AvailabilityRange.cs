using System;

namespace FromCoderToEngineer.Samples.Chapter1.NakedPropertiesAndCollections
{
    public class AvailabilityRange
    {
        public AvailabilityRange(DateTime minimum, DateTime maximum)
        {
            Minimum = minimum;
            Maximum = maximum;
        }

        // Other properties and methods omitted for brevity.
        public DateTime Minimum { get; }

        public DateTime Maximum { get; }
    }
}