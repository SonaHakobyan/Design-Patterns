using Newtonsoft.Json;

namespace Prototype
{
    public static class Json
    {
        /// <summary>
        /// Generic deep clone
        /// </summary>
        /// <typeparam name="T">Type of self</typeparam>
        /// <param name="self">Given obj</param>
        /// <returns>Cloned obj</returns>
        public static T DeepCopy<T>(this T self)
        {
            var serialized = JsonConvert.SerializeObject(self);
            return JsonConvert.DeserializeObject<T>(serialized);
        }
    }
}
