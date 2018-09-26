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
    public class FishController
        : BasePetWorksApiController
    {
        public FishController(IReadOnlyList<IPetService> petServices, ILoggingService loggingService)
            :base(petServices, loggingService)
        {
        }

        [HttpGet]
        [Route("api/fish")]
        public HttpResponseMessage Get()
        {
            this.LogMessage("GET /fish requested.");

            var service = this.PetServices
                .FirstOrDefault(s => s.CanHandle(Shared.Enumerations.PetType.Fish));

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
