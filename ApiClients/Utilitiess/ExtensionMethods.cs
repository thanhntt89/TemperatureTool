using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TemperatureTool.ApiClients.Utilitiess
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// Validates if string is a valid JSON
        /// </summary>
        /// <param name="stringValue">String to validate</param>
        /// <returns></returns>
        public static bool IsValidJson(this string stringValue)
        {
            if (string.IsNullOrWhiteSpace(stringValue))
            {
                return false;
            }

            var value = stringValue.Trim();

            if ((value.StartsWith("{") && value.EndsWith("}")) || //For object
                (value.StartsWith("[") && value.EndsWith("]"))) //For array
            {
                try
                {
                    var obj = JToken.Parse(value);
                    return true;
                }
                catch (JsonReaderException)
                {
                    return false;
                }
            }

            return false;
        }
    }
}
