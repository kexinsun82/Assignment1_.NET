using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q6 : ControllerBase
    {
        /// <summary>
        /// Returns the area of a regular hexagon with side length double {S} using the formula. You may assume {S}>0.
        /// </summary>
        /// <param name="Side">The length of one side of the hexagon.</param>
        /// <returns>Returns the calculated area of the hexagon.</returns>
        /// <example>
        /// Get: api/q6/hexagon?side=1 => 2.598076211353316
        /// Get: api/q6/hexagon?side=1.5 => 5.845671475544961
        /// Get: api/q6/hexagon?side=20 => 1039.2304845413264
        /// </example>
        [HttpGet(template: "Hexagon")]
        public double Hexagon(double Side)
        {
            double area = (3 * Math.Sqrt(3) / 2) * Math.Pow(Side, 2);
            return area;
        }
    }
}