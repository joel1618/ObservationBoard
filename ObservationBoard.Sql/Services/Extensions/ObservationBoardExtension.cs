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
                Id = item.Id,
                Client = item.Client,
                OpenedTimeStamp = item.OpenedTimeStamp,
                AssignedBed = item.AssignedBed,
                Status = item.Status,
                AccompaniedBy = item.AccompaniedBy,
                DemographicTimeStamp = item.DemographicTimeStamp,
                GeneralConsentTimeStamp = item.GeneralConsentTimeStamp,
                Photo = item.Photo,
                PhotoTimeStamp = item.PhotoTimeStamp,
                Ansa = item.Ansa,
                CrisisScreeningTimeStamp = item.CrisisScreeningTimeStamp,
                AssessmentTimeStamp = item.AssessmentTimeStamp,
                FinancialTimeStamp = item.FinancialTimeStamp,
                EAndMTimeStamp = item.EAndMTimeStamp,
                ROSTimeStamp = item.ROSTimeStamp,
                UDSTimeStamp = item.UDSTimeStamp,
                FollowUpAndDisposition = item.FollowUpAndDisposition,
                LastNursingAssessmentTimeStamp = item.LastNursingAssessmentTimeStamp,
                SubUnitId = item.SubUnitId,
                BedsOccupied = item.BedsOccupied,
                BedsAvailable = item.BedsAvailable
            };
        }
    }
}
