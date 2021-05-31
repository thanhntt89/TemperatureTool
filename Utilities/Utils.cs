using Newtonsoft.Json;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using TemperatureTool.ApiClients.Config;

namespace TemperatureTool.ApiClients.Utilitiess
{
    public class Utils
    {
        /// <summary>
        /// Check data is number
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static bool IsNumeric(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return false;
            return value.All(char.IsNumber);
        }

        /// <summary>
        /// Gets an HttpMethod object based on a string.
        /// </summary>
        /// <param name="method">Name of the HttpMethod to create.</param>
        /// <returns>HttpMethod object.</returns>
        public static HttpMethod CreateHttpMethod(string method)
        {
            switch (method.ToUpper())
            {
                case "DELETE":
                    return HttpMethod.Delete;
                case "POST":
                    return HttpMethod.Post;
                case "PUT":
                    return HttpMethod.Put;
                case "GET":
                    return HttpMethod.Get;
                default:
                    throw new NotImplementedException();
            }
        }

        public static HttpContent CreateHttpContent(object content)
        {
            HttpContent httpContent = null;

            if (content != null)
            {
                var ms = new MemoryStream();
                SerializeJsonIntoStream(content, ms);
                ms.Seek(0, SeekOrigin.Begin);
                httpContent = new StreamContent(ms);
                httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            }

            return httpContent;
        }

        private static void SerializeJsonIntoStream(object value, Stream stream)
        {
            using (var sw = new StreamWriter(stream, new UTF8Encoding(false), 1024, true))
            using (var jtw = new JsonTextWriter(sw) { Formatting = Newtonsoft.Json.Formatting.None })
            {
                var js = new JsonSerializer();
                js.Serialize(jtw, value);
                jtw.Flush();
            }
        }

        /// <summary>
        /// Gets a HMACSHA256 signature based on the API Secret.
        /// </summary>
        /// <param name="apiSecret">Api secret used to generate the signature.</param>
        /// <param name="message">Message to encode.</param>
        /// <returns></returns>
        public static string GenerateSignature(string apiSecret, string message)
        {
            var key = Encoding.Default.GetBytes(apiSecret);
            string stringHash;
            using (var hmac = new HMACSHA256(key))
            {
                var hash = hmac.ComputeHash(Encoding.Default.GetBytes(message));
                stringHash = Convert.ToBase64String(hash).TrimEnd('=');
            }

            return stringHash;
        }
    
        /// <summary>
        /// Serializes an object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="serializableObject"></param>
        /// <param name="fileName"></param>
        public static void SerializeObject<T>(T serializableObject, string fileName)
        {
            if (serializableObject == null) { return; }

            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                XmlSerializer serializer = new XmlSerializer(serializableObject.GetType());
                using (MemoryStream stream = new MemoryStream())
                {
                    serializer.Serialize(stream, serializableObject);
                    stream.Position = 0;
                    xmlDocument.Load(stream);
                    xmlDocument.Save(fileName);
                }
            }
            catch (Exception)
            {
                //Log exception here
            }
        }

        /// <summary>
        /// Deserializes an xml file into an object list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static T DeSerializeObject<T>(string fileName)
        {
            if (string.IsNullOrEmpty(fileName)) { return default(T); }

            T objectOut = default(T);

            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(fileName);
                string xmlString = xmlDocument.OuterXml;

                using (StringReader read = new StringReader(xmlString))
                {
                    Type outType = typeof(T);

                    XmlSerializer serializer = new XmlSerializer(outType);
                    using (XmlReader reader = new XmlTextReader(read))
                    {
                        objectOut = (T)serializer.Deserialize(reader);
                    }
                }
            }
            catch (Exception)
            {
                //Log exception here
            }

            return objectOut;
        }

        public static void SerializeObjectToBinary<T>(T serializableObject, string fileName)
        {
            if (serializableObject == null) { return; }

            // To serialize the hashtable and its key/value pairs,
            // you must first open a stream for writing.
            // In this case, use a file stream.
            FileStream fs = new FileStream(fileName, FileMode.Create);

            // Construct a BinaryFormatter and use it to serialize the data to the stream.
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(fs, serializableObject);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }
        }

        public static T DeSerializeBinaryObject<T>(string filePath)
        {
            if (string.IsNullOrEmpty(filePath)) { return default(T); }

            // Open the file containing the data that you want to deserialize.
            FileStream fs = new FileStream(filePath, FileMode.Open);
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();

                // Deserialize the hashtable from the file and
                // assign the reference to the local variable.
                return (T)formatter.Deserialize(fs);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }
        }

        internal static void CreateDefaultConfig(string filePath)
        {
            if (File.Exists(filePath))
                return;
            ApiConfig apiConfig = new ApiConfig()
            {
                ApiInfos = new ApiInfo()
                {
                    ApiKey = "xxx",
                    ApiSecret = "YXdQqqC8jaPCo9FGT7efHbZP15T14Nxn",
                    ApiUrl = "https://sgd8ee3kf5.execute-api.ap-northeast-1.amazonaws.com/"
                },
                EnpointInfo = new EndPointInfo()
                {
                    Login = "/Prod/user/login",
                    UserList = "api/users/count",
                    UserRegiester = "/Prod/user/register",
                    UserUpdatePassword = "/Prod/user/updatepassword",
                    UserResetPassword = "/Prod/user/resetpassword",
                    UserDelete = "/Prod/user/delete",
                    CountClientUrl = "/Prod/users/count",
                    SearchClientUrl = "/Prod/user/list",
                    ExportClientUrl = "/Prod/users/export",
                    ExportCSVUrl = "https://mytelwebhook.ebot.chat/exportCsv"                    
                }
            };
            try
            {
                SerializeObject<ApiConfig>(apiConfig, filePath);
            }
            catch
            {

            }
        }


        public static void FastAutoSizeColumns(DataGridView targetGrid)
        {
            // BindingSource bs = new BindingSource();
            // bs.DataSource = targetGrid.DataSource;
            BindingSource bs = (BindingSource)targetGrid.DataSource;
            if (bs == null)
                return;
            DataTable gridTable = (DataTable)bs.DataSource;


            // Cast out a DataTable from the target grid datasource.
            // We need to iterate through all the data in the grid and a DataTable supports enumeration.           

            // Create a graphics object from the target grid. Used for measuring text size.
            using (var gfx = targetGrid.CreateGraphics())
            {
                // Iterate through the columns.
                for (int i = 0; i < gridTable.Columns.Count; i++)
                {
                    // Leverage Linq enumerator to rapidly collect all the rows into a string array, making sure to exclude null values.
                    string[] colStringCollection = gridTable.AsEnumerable().Where(r => r.Field<object>(i) != null).Select(r => r.Field<object>(i).ToString().Trim()).ToArray();

                    // Sort the string array by string lengths.
                    colStringCollection = colStringCollection.OrderBy((x) => x.Length).ToArray();

                    if (colStringCollection.Count() == 0)
                        continue;

                    // targetGrid.Columns[i].HeaderText.Length;

                    // Get the last and longest string in the array.
                    string longestColString = colStringCollection.Last();

                    // Use the graphics object to measure the string size.
                    int colWidth = (int)gfx.MeasureString(longestColString, targetGrid.Font).Width;

                    int headerTitleWidth = (int)gfx.MeasureString(targetGrid.Columns[i].HeaderText, targetGrid.Font).Width + 20;
                    int currentHeaderWidth = targetGrid.Columns[i].Width;

                    // If the calculated width is larger than the column header width, set the new column width.
                    if (colWidth > currentHeaderWidth)//targetGrid.Columns[i].HeaderCell.Size.Width)
                    {
                        targetGrid.Columns[i].Width = colWidth > 2 * currentHeaderWidth ? 2 * currentHeaderWidth : colWidth;
                    }
                    else if (headerTitleWidth > currentHeaderWidth) // Otherwise, set the column width to the header width.
                    {
                        targetGrid.Columns[i].Width = currentHeaderWidth > headerTitleWidth ? currentHeaderWidth : 2 * headerTitleWidth - currentHeaderWidth;
                    }

                }
            }
        }
                
    }

}
