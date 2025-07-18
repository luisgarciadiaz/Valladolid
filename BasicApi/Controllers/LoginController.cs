using Microsoft.AspNetCore.Mvc;

namespace BasicApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            // Simple in-memory user check (replace with your user store)
            if (request.Username == "admin" && request.Password == "password")
            {
                return Ok(new { message = "Login successful" });
            }
            return Unauthorized();
        }
    }
}