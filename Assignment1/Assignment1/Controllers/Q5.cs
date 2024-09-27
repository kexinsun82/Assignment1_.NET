using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q5 : ControllerBase
    {
        /// <summary>
        /// Receives an HTTP POST request with a body and provides a response message.
        /// </summary>
        /// <param name="secret"></param>
        /// <returns>Returns an acknowledgement of the {secret} integer</returns>
        /// <example>
        /// POST: api/q5/secret
        /// Content-Type: application/json
        /// REQUEST BODY: 5 -> Shh.. the secret is 5
        /// Content-Type: application/json
        /// REQUEST BODY: -200 -> Shh.. the secret is -200
        /// </example>
        [HttpPost(template: "Secret")]
        [Consumes("Application/json")]
        public string Secret([FromBody] int secret)
        {
            return $"Shh.. the secret is {secret}";
        }
    }
}


        