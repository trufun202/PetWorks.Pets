using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using PetWorks.Shared.Controllers;
using PetWorks.Shared.Services.Interfaces;

namespace PetWorks.Pets.Dogs.Controllers
{
    public class CatsController
        : BasePetWorksApiController
    {
        public CatsController(IReadOnlyList<IPetService> petServices, ILoggingService loggingService)
            :base(petServices, loggingService)
        {
        }

        [HttpGet]
        [Route("api/cats")]
        public HttpResponseMessage Get()
        {
            this.LogMessage("GET /cats requested.");

            var service = this.PetServices
                .FirstOrDefault(s => s.CanHandle(Shared.Enumerations.PetType.Cat));

            if (service != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, service.GetPets());
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "No service found for this request.");
            }
        }
    }
}
