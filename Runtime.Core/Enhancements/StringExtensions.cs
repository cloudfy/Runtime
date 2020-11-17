using System.Collections.Generic;
using System.Text;

namespace Runtime.Enhancements
{
    /// <summary>
    /// 
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Returns true if value is null or empty.
        /// </summary>
        /// <param name="value">String value.</param>
        /// <returns></returns>
        public static bool IsEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }
        /// <summary>
        /// Returns false if value is null or empty.
        /// </summary>
        /// <param name="value">String value.</param>
        /// <returns></returns>
        public static bool IsNotEmpty(this string value)
        {
            return !string.IsNullOrEmpty(value);
        }
        /// <summary>
        /// Returns the alternative if value empty.
        /// </summary>
        /// <param name="value">Value to check if empty.</param>
        /// <param name="alternative">Non-nullable string.</param>
        /// <returns></returns>
        public static string IfEmpty(this string value, string alternative)
        {
            Assert.Required(alternative);

            if (value.IsEmpty())
                return alternative;

            return value;
        }
    }
}
