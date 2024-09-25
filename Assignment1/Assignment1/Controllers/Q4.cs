using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q4 : ControllerBase
    {
        /// <summary>
        /// Receives an HTTP POST request with an empty body and provides a response message.
        /// </summary>
        /// <returns>Returns the start of a knock knock joke.</returns>
        /// <example>
        /// POST: api/q4/knockknock
        /// REQUEST HEADERS: (NONE)
        /// REQUEST BODY: (NONE)
        /// </example>
        [HttpPost(template: "knockknock")]
        public string knockknock()
        {
            return "Who's there?";
        }
    }
}
