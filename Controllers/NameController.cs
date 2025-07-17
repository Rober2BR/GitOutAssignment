using Microsoft.AspNetCore.Mvc;

namespace GitOutAssignment.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NameController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetName()
        {
            var response = new { Name = "Brandon Roberts" };
            return Ok(response);
        }
    }
}