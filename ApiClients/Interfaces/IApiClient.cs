using System.Threading.Tasks;
using TemperatureTool.ApiClients.Enums;

namespace TemperatureTool.ApiClients.Interfaces
{
    public interface IApiClient
    {
        /// <summary>
        /// Call api funtction
        /// </summary>
        /// <typeparam name="T">Models</typeparam>
        /// <param name="apiMethod">Method</param>
        /// <param name="endPoint">Function api</param>
        /// <param name="isSinged">isSinged</param>
        /// <param name="body">parameters</param>
        /// <returns></returns>     
        Task<T> CallAsync<T>(ApiMethod apiMethod, string endPoint, string body = null, string parameters = null);
    }
}
