using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q1 : ControllerBase
    {

        /// <summary>
        /// an HTTP GET and returns a welcome message
        /// </summary>
        /// <returns>Returns a welcome message</returns>
        /// <example>
        /// Get: api/q1/welcome -> "Welcome to 5125!"
        /// </example>
        [HttpGet(template: "Welcome")]
        public string Welcome()
        {
            return "Welcome to 5125!";
        }
    }
}
