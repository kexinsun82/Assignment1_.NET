using System.Globalization;
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
        /// <returns>Returns the checkout summary for an order</returns>
        /// <example>
        /// Post: api/q8/squashfellows
        /// Content-Type: application/x-www-form-urlencoded
        /// Request body: 
            /// Small=1&Large=1
            /// Small=2&Large=1
            /// Small=100&Large=100
        /// </example>
        [HttpPost(template: "SquashFellows")]
        [Consumes("application/x-www-form-urlencoded")]
        public string SquashFellows([FromForm]int Small, [FromForm]int Large)
        {
            double SmallPrice = 25.50;
            double LargePrice = 40.50;
            double SmallTotal = Math.Round(Small * SmallPrice, 2);
            double LargeTotal = Math.Round(Large * LargePrice, 2);
            double Subtotal = SmallTotal + LargeTotal;
            double Tax = Math.Round(Subtotal * 0.13, 2);
            double Total = Subtotal + Tax;

            string SmallTotalFormat = SmallTotal.ToString("C", CultureInfo.CreateSpecificCulture("en-CA"));
            string LargeTotalFormat = LargeTotal.ToString("C", CultureInfo.CreateSpecificCulture("en-CA"));
            string SubtotalFormat = Subtotal.ToString("C", CultureInfo.CreateSpecificCulture("en-CA"));
            string TaxFormat = Tax.ToString("C", CultureInfo.CreateSpecificCulture("en-CA"));
            string TotalFormat = Total.ToString("C", CultureInfo.CreateSpecificCulture("en-CA"));
            
            return $"{Small} Small @ {SmallPrice} = {SmallTotalFormat}; {Large} Large @ {LargePrice} = {LargeTotalFormat}; Subtotal = {SubtotalFormat}; Tax = {TaxFormat} HST; Total = {TotalFormat}";
        }
    }
}