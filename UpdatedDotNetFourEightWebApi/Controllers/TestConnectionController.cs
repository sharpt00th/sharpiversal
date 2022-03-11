using Microsoft.PowerPlatform.Dataverse.Client;
using UpdatedDotNetFourEightWebApi.Models;
using System;
using System.Web.Http;

namespace UpdatedDotNetFourEightWebApi.Controllers
{
    public class TestConnectionController : ApiController
    {
        /// <summary>
        /// Default action. POST to  https://localhost:XXXX/api/TestConnection
        /// </summary>
        /// <param name="request">See example below.</param>
        /// <returns>ServiceClient instance if successfully created.</returns>
        /// <example>
        /// {
        ///    "InstanceUrl": "https://xxxxxx.xxxx.dynamics.com",
        ///    "ClientId": "00000000-0000-0000-0000-000000000000",
        ///    "ClientSecret": "abc123"
        /// }
        /// </example>
        [HttpPost]
        public IHttpActionResult Call(TestConnectionRequest request)
        {
            try
            {
                var client = new ServiceClient(new Uri(request.InstanceUrl), request.ClientId, request.ClientSecret, true);
                return Content(System.Net.HttpStatusCode.OK, client);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
