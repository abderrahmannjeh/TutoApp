using TutoApp.Dto;

namespace TutoApp.Metier.Interface
{
    public interface IAuthService
    {
        Task<string> RegisterUser(UserDTO model);
        Task<string> LoginUser(UserDTO model);
    }
}