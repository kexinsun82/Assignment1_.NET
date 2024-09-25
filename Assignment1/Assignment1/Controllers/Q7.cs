using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q7 : ControllerBase
    {
        /// <summary>
        /// Receives an HTTP GET request with one integer route parameter and provides a response message.
        /// </summary>
        /// <param name="days"></param>
        /// <returns>An HTTP response with a body echoing the value of days.</returns>
        /// <example>
        /// Get: api/q7/timemachine?days=1 => 2000-01-02
        /// Get: api/q7/timemachine?days=-1 => 1999-12-31
        /// </example>
        [HttpGet(template: "Timemachine")]
        public string Timemachine(int days)
        {
            DateTime today = DateTime.Now;
            DateTime answer = today.AddDays(days);
            return answer.ToString("yyyy-MM-dd");
        }
    }
}
