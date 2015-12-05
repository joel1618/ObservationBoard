using System.Collections.Generic;
using System.Linq;
using ObservationBoard.Services.Interfaces;
using ObservationBoard.Services.Extensions;
using System.Threading.Tasks;
using ObservationBoardCore = ObservationBoard.Models.ObservationBoard;

namespace ObservationBoard.Services
{
    public class ObservationBoardService : IObservationBoardService
    {
        ObservationBoardEntities _context = new ObservationBoardEntities();
        public ObservationBoardService(ObservationBoardEntities context)
        {
            _context = context;
        }

        public async Task<List<ObservationBoardCore>> GetAll()
        {
            return _context.ObservationBoards.ToList().Select(x => x.ToCore()).ToList();
        }
    }
}