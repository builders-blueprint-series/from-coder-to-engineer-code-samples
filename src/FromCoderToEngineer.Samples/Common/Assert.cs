using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FromCoderToEngineer.Samples.Common
{
    public static class Assert
    {
        public static void IsNotNull(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
        }

        public static void IsAlphaOnly(string obj)
        {
            var regex = new Regex("/^[A-Z]+$/i");

            if (!regex.IsMatch(obj))
            {
                throw new ArgumentException("String contains non alpha characters.");
            }
        }
    }
}
