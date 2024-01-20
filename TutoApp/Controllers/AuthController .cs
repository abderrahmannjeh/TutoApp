using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TutoApp.Dto;
using TutoApp.Metier.Implementation;
using TutoApp.Metier.Interface;

namespace TutoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<LoginResponse> Register([FromBody] UserDTO model)
        {
            try
            {
                var registerResult = await _authService.RegisterUser(model);

                if (registerResult != null)
                {
                    return registerResult;
                }

                return new LoginResponse() { HasError = true, Error = "Registration failed" };
            }
            catch (Exception ex)
            {
                return new LoginResponse() { HasError = true, Error = ex.Message };
            }
        }

        [HttpPost("login")]
        public async Task<LoginResponse> Login([FromBody] UserDTO model)
        {
            try
            {
                var result = await _authService.LoginUser(model);

                if (result != null)
                {
                    return result;
                }
                return new LoginResponse() { HasError = true, Error = "Login failed" };
            }
            catch(Exception ex) {

                return new LoginResponse() { HasError = true, Error = ex.Message };
            }

      
        }
    }
}

