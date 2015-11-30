using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using ObservationBoard.Models;
using ObservationBoardCore = ObservationBoard.Models.ObservationBoard;

namespace ObservationBoard.API
{
    public class ObservationBoardController : ApiController
    {
        //TODO: Inject a service or repo that will serve the data from sql.  
        //TODO: Authorize the action if exposed publicly.
        ObservationBoardCore[] clients = new ObservationBoardCore[]
        {
            new ObservationBoardCore { Id = 1 },
            new ObservationBoardCore { Id = 2 },
            new ObservationBoardCore { Id = 3 }
        };
        public IEnumerable<ObservationBoardCore> GetAll()
        {
            return clients;
        }
    }
}