using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NZWalks.API.Controllers
{   //http://localhost:portnumber/api/students
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        // GET: http://localhost:portnumber/api/students
        [HttpGet]
        public IActionResult GetAllSTudetns()
        {
            string[] studentNames= new string[] { "A", "B", "C", "D" };
            return Ok(studentNames);   

        }
    }
}
