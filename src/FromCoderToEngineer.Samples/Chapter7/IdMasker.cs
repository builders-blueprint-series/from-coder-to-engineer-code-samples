using System;

namespace FromCoderToEngineer.Samples.Chapter7
{
    public static class IdMasker
    {
        public static string MaskId(Guid id)
        {
            const int startingIndex = 0;
            const int length = 8;

            return id.ToString().Substring(startingIndex, length);
        }

        public static string MaskId(object obj)
        {
            const int startingIndex = 0;
            const int length = 8;

            return obj.ToString().Substring(startingIndex, length);
        }
    }
}