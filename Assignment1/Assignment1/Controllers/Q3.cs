using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q3 : ControllerBase
    {
        /// <summary>
        /// Receives a number and outputs the number
        /// </summary>
        /// <returns>An HTTP response with a body indicating the usage, echoing the value of base.</returns>
        /// <example>
        /// Get: api/q3/Cube/4 -> 64
        /// Get: api/q3/Cube/-4 -> -64
        /// Get: api/q3/Cube/10 -> 1000
        /// </example>
        [HttpGet(template: "Cube/{Base}")]
        public int Cube(int Base)
        {
            int Number = Base * Base * Base;
            return Number;
        }
    }
}
