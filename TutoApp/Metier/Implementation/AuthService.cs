using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TutoApp.Entity;
using TutoApp.Dto;
using TutoApp.Metier.Interface;

namespace TutoApp.Metier.Implementation



{
    public class AuthService: IAuthService
    {
        private readonly UserManager<User> _userManager;
        private readonly IConfiguration _configuration;

        public AuthService(UserManager<User> userManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _configuration = configuration;
        }

        public async Task<LoginResponse> RegisterUser(UserDTO model)
        {
            var user = new User
            {
                UserName = model.Email,
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Type = (bool)model.IsStore?"Store":"Client",
                ConnectionString="test"
            };

            var userCheck = await _userManager.FindByEmailAsync(user.Email);
            if(userCheck != null)
            {
                throw new Exception("User Exist With this email");
            }

            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
              return  new LoginResponse() { Token=GenerateJwtToken(user),
                                      Email=model.Email,
                                      FirstName=model.FirstName,
                                      LastName=model.LastName,
                                      HasError=false,
                                      IsStore=model.IsStore,
                                    };
            }
            else
            {
                var error = string.Empty;
                foreach(var e in result.Errors)
                {
                    error =  error + "*"+e.Description;
                }
                throw new Exception(error);
            }

        }

        public async Task<LoginResponse> LoginUser(UserDTO model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);

            if (user != null && await _userManager.CheckPasswordAsync(user, model.Password))
            {
                return new LoginResponse()
                {
                    Token = GenerateJwtToken(user),
                    Email = user.Email,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    HasError = false,
                    IsStore = user.Type =="Store"?true:false,
                }; ;
            }

            throw new Exception("Password Or Email not correct");
        }

        private string GenerateJwtToken(User user)
        {
            var claims = new List<Claim>
        {
            new Claim(ClaimTypes.NameIdentifier, user.Id),
            new Claim(ClaimTypes.Name, user.UserName),
            // Add other claims as needed
        };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expires = DateTime.Now.AddDays(Convert.ToDouble(_configuration["Jwt:ExpireDays"]));

            var token = new JwtSecurityToken(
                _configuration["Jwt:Issuer"],
                _configuration["Jwt:Audience"],
                claims,
                expires: expires,
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }


}