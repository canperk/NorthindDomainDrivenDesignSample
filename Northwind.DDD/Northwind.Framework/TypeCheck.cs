using System;

namespace Northwind.Framework
{
    public class TypeCheck
    {
        public static T IsNull<T>(T value)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));
            return value;
        }

        public static string IsNullOrEmpty(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentNullException(nameof(value));
            return value;
        }
    }
}
