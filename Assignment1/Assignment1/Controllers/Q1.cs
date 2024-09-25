using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q1 : ControllerBase
    {

        // Get: api/q1/welcome -> "Welcome to 5125!"
        [HttpGet(template: "Welcome")]
        public string Welcome()
        {
            return "Welcome to 5125!";
        }
    }
}
