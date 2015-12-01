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

        //TODO: Inject a service or repo that will serve the data from sql.  
        //TODO: Authorize the action if exposed publicly.
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