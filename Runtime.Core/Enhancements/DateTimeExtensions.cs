using System;
using System.Collections.Generic;
using System.Text;

namespace Runtime.Enhancements
{
    /// <summary>
    /// 
    /// </summary>
    public static class DateTimeExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        internal static bool IsThisMonth(this DateTime value)
        {
            return DateTime.UtcNow.Year == value.Year && DateTime.UtcNow.Month == value.Month;
        }
    }
}
