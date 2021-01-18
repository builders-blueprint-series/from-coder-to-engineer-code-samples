namespace FromCoderToEngineer.Samples.Chapter7
{
    using System;

    public class ModifiedCustomer
    {
        private const int MaskedIdStartIndex = 0;
        private const int MaskedIdLength = 8;
        private Guid _id;

        public ModifiedCustomer(Guid id)
        {
            _id = id;
        }

        public string Id => _id.ToString().Substring(MaskedIdStartIndex, MaskedIdLength);
    }
}
