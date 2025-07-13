using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Assignment5.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "Admin")] // ✅ Only 'Admin' role can access
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("🎉 Welcome Admin! You can access employee data.");
        }
    }
}
