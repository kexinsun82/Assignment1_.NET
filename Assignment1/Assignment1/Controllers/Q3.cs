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
        /// <param name="Base"></param>
        /// <returns>Returns the cube of the integer {base}</returns>
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
        