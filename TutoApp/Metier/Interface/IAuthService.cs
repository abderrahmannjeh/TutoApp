using TutoApp.Dto;

namespace TutoApp.Metier.Interface
{
    public interface IAuthService
    {
        Task<LoginResponse> RegisterUser(UserDTO model);
        Task<LoginResponse> LoginUser(UserDTO model);
    }
}