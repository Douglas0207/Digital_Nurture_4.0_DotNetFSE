using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authorization;


namespace Assignment5.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        // 🔐 Secret key (should match Program.cs)
        private readonly string securityKey = "mysuperdupersecretkeyformyapi123456";


        // ✅ Endpoint to generate JWT token
        [HttpGet("login")]
        [AllowAnonymous]
        public IActionResult Login()
        {
            var token = GenerateJSONWebToken(1, "Admin"); // If we change this then we will get 403 forbidden 
                                                          // since employeecontroller uses admin and here we change the name we get a 403 , if employeecontroller is also a different name
                                                          // we would get a 401 unAuthorized
            return Ok(new { token });
        }

        // 🔧 Method to create the JWT token
        private string GenerateJSONWebToken(int userId, string userRole)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(ClaimTypes.Role, userRole),
                new Claim("UserId", userId.ToString())
            };

            var token = new JwtSecurityToken(
                issuer: "mySystem",
                audience: "myUsers",
                claims: claims,
                expires: DateTime.Now.AddMinutes(2),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
