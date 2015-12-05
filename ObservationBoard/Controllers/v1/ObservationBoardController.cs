using System.Web.Http;
using ObservationBoard.Services.Interfaces;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net;
using System.Collections.Generic;
using ObservationBoard.Extensions;
using System.Linq;
using ObservationBoardCore = ObservationBoard.Models.ObservationBoard;

namespace ObservationBoard.API
{
    public class ObservationBoardController : ApiController
    {

        public IObservationBoardService _service;
        public ObservationBoardController(IObservationBoardService service)
        {
            _service = service;
        }
        //TODO: Create search endpoint (server side sorting, filtering, paging)
        //TODO: Authorize the action if exposed publicly.
        // http://www.asp.net/web-api/overview/security/authentication-filters
        //TODO: Work on explicit path routing
        //  http://stackoverflow.com/questions/21152168/adding-an-explicit-action-route-to-asp-net-web-api-controller
        //TODO: Think about attribute routing
        //  http://www.asp.net/web-api/overview/web-api-routing-and-actions/attribute-routing-in-web-api-2
        //TODO: Here we can lockdown the app to be only used on the domain.
        //[Authorize(Roles = "DOMAIN\\GROUP")]
        public HttpResponseMessage GetAll()
        {
            List<ObservationBoardCore> clients = _service.GetAll().Result;
            
            return Request.CreateResponse(HttpStatusCode.OK, clients.Select(x => x.ToViewModel()));
        }
    }
}
