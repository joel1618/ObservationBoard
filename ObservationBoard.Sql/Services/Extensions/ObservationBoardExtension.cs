using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObservationBoardCore = ObservationBoard.Models.ObservationBoard;

namespace ObservationBoard.Services.Extensions
{
    public static class ObservationBoardExtension
    {
        public static ObservationBoardCore ToCore(this ObservationBoard item)
        {
            return new ObservationBoardCore()
            {
                Id = item.Id
            };
        }
    }
}
