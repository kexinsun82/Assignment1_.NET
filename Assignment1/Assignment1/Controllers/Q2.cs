using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q2 : ControllerBase
    {
      /// <summary>
        /// Receives an HTTP GET request with one query parameter and provides a response message.
        /// </summary>
        /// <returns>An HTTP response with a body indicating the usage, echoing the value of queryParam1.</returns>
        /// <example>
        /// Get: api/q2/greeting?name=Gary -> Hi Gary!
        /// Get: api/q2/greeting?name=Ren%C3%A9e -> Hi Renée!
        /// </example>
        /// <remarks>
        /// Allowed in URL: 
        /// Uppercase alpha (A-Z), lowercase alpha (a-z), numerical (0-9), - _ . ~ 
        /// Reserved in URL: 
        /// @ : / ? &  = # % + [ ] ! $ ( ) * , ;
        /// Characters not in the allowed list, or reserved characters used outside of their special meaning, must be "URL encoded".
        /// i.e. test@test.ca -> test%40test.ca
        /// </remarks>
      [HttpGet(template: "Greeting")]
        public string Greeting(string name)
        {
            return $"Hi {name}!";
        }
    }
}
