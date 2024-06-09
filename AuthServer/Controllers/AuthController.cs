using AuthServer.Core;
using Microsoft.AspNetCore.Mvc;

namespace AuthServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IAuthService _authService;

        public AuthController(IUserService userService, IAuthService authService)
        {
            _userService = userService;
            _authService = authService;
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] User user)
        {
            if (_userService.GetUserByUsernameAsync(user.Username).Result != null)
                return BadRequest("User already exists");

            _userService.RegisterAsync(user).Wait(); // Make sure to call async methods properly
            return Ok();
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] User user)
        {
            var existingUser = _userService.GetUserByUsernameAsync(user.Username).Result;
            if (existingUser == null || existingUser.PasswordHash != user.PasswordHash)
                return Unauthorized();

            var token = _authService.GenerateJwtToken(existingUser);
            return Ok(new { Token = token });
        }
    }
}
