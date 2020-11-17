using System;

namespace Runtime.Enhancements
{
    /// <summary>
    /// Provides extensions for Guids.
    /// </summary>
    public static class GuidExtensions
    {
        /// <summary>
        /// Returns True if object is a guid.
        /// </summary>
        /// <param name="value">Object to validate as a guid.</param>
        /// <returns></returns>
        public static bool IsGuid(this object value)
        {
            try
            {
                Guid.Parse(value.ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
