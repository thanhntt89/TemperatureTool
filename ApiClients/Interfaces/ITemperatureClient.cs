using static TemperatureTool.ApiClients.Actions.ClientActions;
using static TemperatureTool.ApiClients.Actions.ExportActions;
using static TemperatureTool.ApiClients.Actions.LoginActions;
using static TemperatureTool.ApiClients.Actions.UserActions;

namespace TemperatureTool.ApiClients.Interfaces
{
    public interface ITemperatureClient
    {
        LoginResponse GetLoginInfo(LoginRequest request);
        UserListResponse GetTAdminUsers(UserListRequest request);
        UserRegisterResponse RegisterTAdminUser(UserRegisterRequest request);
        UserResetPasswordResponse ResetPasswordTAdminUser(UserResetPasswordRequest request);
        UserChangePasswordResponse ChangePasswordTAdminUser(UserChangePasswordRequest request);
        UserDeleteResponse DeleteTAdminUser(UserDeleteRequest request);

        SearchClientsResponse SearchClients(SearchClientsRequest req);
        ExportClientResponse ExportClients(ExportClientsRequest req);
        CountClientsResponse CountClients(CountClientsRequest req);
        ExportResponse ExportCSV(ExportRequest request);
    }
}
