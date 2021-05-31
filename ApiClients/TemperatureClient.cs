using Newtonsoft.Json;
using System.Threading.Tasks;
using TemperatureTool.ApiClients.Abstract;
using TemperatureTool.ApiClients.Actions;
using TemperatureTool.ApiClients.Config;
using TemperatureTool.ApiClients.Enums;
using TemperatureTool.ApiClients.Interfaces;
using static TemperatureTool.ApiClients.Actions.ClientActions;
using static TemperatureTool.ApiClients.Actions.ExportActions;
using static TemperatureTool.ApiClients.Actions.LoginActions;
using static TemperatureTool.ApiClients.Actions.UserActions;

namespace TemperatureTool.ApiClients
{

    public class TemperatureClient : TemperatureClientAbstract, ITemperatureClient
    {
        public TemperatureClient(IApiClient apiClient, EndPointInfo endPointInfo) : base(apiClient, endPointInfo)
        {

        }

        public LoginResponse GetLoginInfo(LoginRequest request)
        {
            var args = JsonConvert.SerializeObject(request);

            var task = Task.Run(() => _apiClient.CallAsync<LoginResponse>(ApiMethod.POST, _endPointInfo.Login, args));
            task.Wait();
            return task.Result;
        }

        public UserListResponse GetTAdminUsers(UserListRequest request)
        {
            var args = JsonConvert.SerializeObject(request);
            var task = Task.Run(() => _apiClient.CallAsync<UserListResponse>(ApiMethod.POST, _endPointInfo.UserList, args));
            task.Wait();
            return task.Result;
        }

        public UserDeleteResponse DeleteTAdminUser(UserDeleteRequest request)
        {
            var args = JsonConvert.SerializeObject(request);
            var task = Task.Run(() => _apiClient.CallAsync<UserDeleteResponse>(ApiMethod.POST, _endPointInfo.UserDelete, args));
            task.Wait();
            return task.Result;
        }

        public UserRegisterResponse RegisterTAdminUser(UserRegisterRequest request)
        {
            var args = JsonConvert.SerializeObject(request);
            var task = Task.Run(() => _apiClient.CallAsync<UserRegisterResponse>(ApiMethod.POST, _endPointInfo.UserRegiester, args));
            task.Wait();
            return task.Result;
        }

        public UserResetPasswordResponse ResetPasswordTAdminUser(UserResetPasswordRequest request)
        {
            var args = JsonConvert.SerializeObject(request);
            var task = Task.Run(() => _apiClient.CallAsync<UserResetPasswordResponse>(ApiMethod.POST, _endPointInfo.UserResetPassword, args));
            task.Wait();
            return task.Result;
        }

        public UserChangePasswordResponse ChangePasswordTAdminUser(UserChangePasswordRequest request)
        {
            var args = JsonConvert.SerializeObject(request);
            var task = Task.Run(() => _apiClient.CallAsync<UserChangePasswordResponse>(ApiMethod.POST, _endPointInfo.UserUpdatePassword, args));
            task.Wait();
            return task.Result;
        }

        public SearchClientsResponse SearchClients(SearchClientsRequest req)
        {
            var args = JsonConvert.SerializeObject(req);
            var task = Task.Run(() => _apiClient.CallAsync<SearchClientsResponse>(ApiMethod.POST, _endPointInfo.SearchClientUrl, args));
            task.Wait();
            return task.Result;
        }

        public ExportClientResponse ExportClients(ExportClientsRequest req)
        {
            var args = JsonConvert.SerializeObject(req);
            var task = Task.Run(() => _apiClient.CallAsync<ExportClientResponse>(ApiMethod.POST, _endPointInfo.ExportClientUrl, args));
            task.Wait();
            return task.Result;
        }

        public ExportResponse ExportCSV(ExportRequest req)
        {
            var args = JsonConvert.SerializeObject(req);
            var task = Task.Run(() => _apiClient.CallAsync<ExportResponse>(ApiMethod.POST, _endPointInfo.ExportCSVUrl, args));
            task.Wait();
            return task.Result;
        }

        public CountClientsResponse CountClients(CountClientsRequest req)
        {
            var args = JsonConvert.SerializeObject(req);
            var task = Task.Run(() => _apiClient.CallAsync<CountClientsResponse>(ApiMethod.POST, _endPointInfo.UserUpdatePassword, args));
            task.Wait();
            return task.Result;
        }        
    }
}
