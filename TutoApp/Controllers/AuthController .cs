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
        public async Task<IActionResult> Register([FromBody] UserDTO model)
        {
            if (ModelState.IsValid)
            {
                var token = await _authService.RegisterUser(model);

                if (token != null)
                {
                    return Ok(new { Token = token });
                }

                return BadRequest("Registration failed");
            }

            return BadRequest(ModelState);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserDTO model)
        {
            var token = await _authService.LoginUser(model);

            if (token != null)
            {
                return Ok(new { Token = token });
            }

            return Unauthorized("Invalid credentials");
        }
    }
}

