using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Runtime.Text.Json
{
    /// <summary>
    /// 
    /// </summary>
    public static class JsonExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public static T ToObject<T>(this string value)
        {
            return JsonConvert.DeserializeObject<T>(value, new JsonSerializerSettings { 
                NullValueHandling = NullValueHandling.Ignore
            });
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string FromObject(this object value)
        {
            return JsonConvert.SerializeObject(value);
        }
    }
}
