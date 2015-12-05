using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObservationBoardCore = ObservationBoard.Models.ObservationBoard;
using ObservationBoardViewModel = ObservationBoard.ViewModels.ObservationBoardViewModel;

namespace ObservationBoard.Extensions
{
    public static class ObservationBoardExtension
    {
        public static ObservationBoardViewModel ToViewModel(this ObservationBoardCore item)
        {
            return new ObservationBoardViewModel()
            {
                Id = item.Id,
                Client = item.Client,
                OpenedTimeStamp = item.OpenedTimeStamp.HasValue ? item.OpenedTimeStamp.Value.ToShortDateString() : "",
                AssignedBed = item.AssignedBed,
                Status = item.Status,
                AccompaniedBy = item.AccompaniedBy,
                DemographicTimeStamp = item.DemographicTimeStamp.HasValue ? item.DemographicTimeStamp.Value.ToShortDateString() : "",
                GeneralConsentTimeStamp = item.GeneralConsentTimeStamp.HasValue ? item.GeneralConsentTimeStamp.Value.ToShortDateString() : "",
                Photo = item.Photo,
                PhotoTimeStamp = item.PhotoTimeStamp.HasValue ? item.PhotoTimeStamp.Value.ToShortDateString() : "",
                Ansa = item.Ansa,
                CrisisScreeningTimeStamp = item.CrisisScreeningTimeStamp.HasValue ? item.CrisisScreeningTimeStamp.Value.ToShortDateString() : "",
                AssessmentTimeStamp = item.AssessmentTimeStamp.HasValue ? item.AssessmentTimeStamp.Value.ToShortDateString() : "",
                FinancialTimeStamp = item.FinancialTimeStamp.HasValue ? item.FinancialTimeStamp.Value.ToShortDateString() : "",
                EAndMTimeStamp = item.EAndMTimeStamp.HasValue ? item.EAndMTimeStamp.Value.ToShortDateString() : "",
                ROSTimeStamp = item.ROSTimeStamp.HasValue ? item.ROSTimeStamp.Value.ToShortDateString() : "",
                UDSTimeStamp = item.UDSTimeStamp.HasValue ? item.UDSTimeStamp.Value.ToShortDateString() : "",
                FollowUpAndDisposition = item.FollowUpAndDisposition,
                LastNursingAssessmentTimeStamp = item.LastNursingAssessmentTimeStamp.HasValue ? item.LastNursingAssessmentTimeStamp.Value.ToShortDateString() : "",
                SubUnitId = item.SubUnitId,
                BedsOccupied = item.BedsOccupied,
                BedsAvailable = item.BedsAvailable
            };
        }
    }
}
