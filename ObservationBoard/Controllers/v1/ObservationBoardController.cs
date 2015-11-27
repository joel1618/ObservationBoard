using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using ObservationBoard.Models;

namespace ObservationBoard.API
{
    public class ObservationBoardController : ApiController
    {
        //TODO: Inject a service or repo that will serve the data from sql.  
        //TODO: Authorize the action if exposed publicly.
        Client[] clients = new Client[]
        {
            new Client { Id = 1 },
            new Client { Id = 2 },
            new Client { Id = 3 }
        };
        public IEnumerable<Client> GetAll()
        {
            return clients;
        }
    }
}