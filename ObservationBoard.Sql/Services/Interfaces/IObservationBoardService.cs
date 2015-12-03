using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObservationBoardCore = ObservationBoard.Models.ObservationBoard;

namespace ObservationBoard.Services.Interfaces
{
    public interface IObservationBoardService
    {
        Task<IEnumerable<ObservationBoardCore>> GetAll();
    }
}
