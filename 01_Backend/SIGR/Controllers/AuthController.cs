using Microsoft.AspNetCore.Mvc;

namespace SIGR.Controllers
{
    [Controller]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        [HttpPost("register")]
        public IActionResult Register([FromBody] RegisterDto dto)
        {
            return Ok(dto);
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginDto dto)
        {
            var user = new { dto.Email, dto.Password };
            return Ok(user);
        }

        public class RegisterDto
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
        }

        public class LoginDto
        {
            public string Email { get; set; }
            public string Password { get; set; }
        }
    }
}
