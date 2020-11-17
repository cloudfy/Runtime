using System;
using System.Collections.Generic;
using System.Text;

namespace Runtime
{
    /// <summary>
    /// Provides methods to demand nullable value checking to ensure code fault tollerance.
    /// </summary>
    public static class Assert
    {
        /// <summary>
        /// Demands value to be non-empty. Throws a ArgumentNullException if null.
        /// </summary>
        /// <param name="value">String value</param>
        /// <exception cref="ArgumentNullException">If value is null.</exception>
        public static void Required(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentNullException(value);
        }
        /// <summary>
        /// Demands value to be non-empty. Throws a ArgumentNullException if null.
        /// </summary>
        /// <param name="value">String value</param>
        /// <param name="message">Message to display.</param>
        /// <exception cref="ArgumentNullException">If value is null.</exception>
        public static void Required(string value, string message)
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentNullException(message);
        }
        /// <summary>
        /// Demands value to be non-nullable.
        /// </summary>
        /// <param name="value">Object value.</param>
        /// <exception cref="ArgumentNullException">If value is null.</exception>
        public static void Required(object value)
        {
            if (value == null)
                throw new ArgumentNullException(value.ToString());
        }
        /// <summary>
        /// Demands value to be non-nullable.
        /// </summary>
        /// <param name="value">Object value.</param>
        /// <param name="message">Message to display.</param>
        public static void Required(object value, string message)
        {
            if (value == null)
                throw new ArgumentNullException(message);
        }
    }
}
