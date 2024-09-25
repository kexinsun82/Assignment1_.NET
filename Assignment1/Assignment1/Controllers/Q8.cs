using System.Numerics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q8 : ControllerBase
    {
        /// <summary>
        /// Receives an HTTP POST request with a form-encoded body containing two parameters.
        /// </summary>
        /// <param name="Small"></param>
        /// <param name="Large"></param>
        /// <returns>An HTTP response with a body echoing the request body parameters.</returns>
        /// <example>
        /// Post: api/q8/squashfellows
        /// Headers: Content-Type: application/x-www-form-urlencoded
        /// Data: Small=1&Large=1
        /// </example>
        [HttpPost(template: "SquashFellows")]
        [Consumes("application/x-www-form-urlencoded")]
        public string SquashFellows([FromForm]double Small, [FromForm]double Large)
        {
            double SmallPrice = 25.50;
            double LargePrice = 40.50;
            double SmallTotal = Math.Round(Small * SmallPrice, 2, MidpointRounding.AwayFromZero);
            double LargeTotal = Math.Round(Large * LargePrice, 2, MidpointRounding.AwayFromZero);
            double Subtotal = Math.Round(SmallTotal + LargeTotal, 2, MidpointRounding.AwayFromZero);
            double Tax = Math.Round(Subtotal * 0.13, 2, MidpointRounding.AwayFromZero);
            double Total = Math.Round(Subtotal + Tax, 2, MidpointRounding.AwayFromZero);

            return $"{Small} Small @ ${SmallPrice:F2} = ${SmallTotal:F2}; {Large} Large @ ${LargePrice:F2} = ${LargeTotal:F2}; Subtotal = ${Subtotal:F2}; Tax = ${Tax:F2} HST; Total = ${Total:F2}";
        }
    }
}
