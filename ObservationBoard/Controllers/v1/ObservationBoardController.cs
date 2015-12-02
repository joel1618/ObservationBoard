using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using ObservationBoard.Models;
using ObservationBoard.Services.Interfaces;
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
        
        //TODO: Authorize the action if exposed publicly.
        // http://www.asp.net/web-api/overview/security/authentication-filters
        //TODO: Make the return type "HttpResponseMessage" so that http errors can be returned correctly along with data on 200 success
        //TODO: Work on explicit path routing
        //  http://stackoverflow.com/questions/21152168/adding-an-explicit-action-route-to-asp-net-web-api-controller
        //TODO: Think about attribute routing
        //  http://www.asp.net/web-api/overview/web-api-routing-and-actions/attribute-routing-in-web-api-2
        //TODO: Add async Task<object> to service layer and then call using await keyword
        public IEnumerable<ObservationBoardCore> GetAll()
        {
            //ObservationBoardCore[] clients = new ObservationBoardCore[]
            //{
            //    new ObservationBoardCore { Id = 1 },
            //    new ObservationBoardCore { Id = 2 },
            //    new ObservationBoardCore { Id = 3 }
            //};
            //return clients;
            var clients = _service.GetAll();
            return clients;
        }
    }
}
