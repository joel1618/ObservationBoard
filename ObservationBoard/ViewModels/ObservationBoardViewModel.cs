using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservationBoard.ViewModels
{
    public class ObservationBoardViewModel
    {
        public int Id { get; set; }
        public string Client { get; set; }
        public string OpenedTimeStamp { get; set; }
        public int? AssignedBed { get; set; }
        public string Status { get; set; }
        public string AccompaniedBy { get; set; }
        public string DemographicTimeStamp { get; set; }
        public string GeneralConsentTimeStamp { get; set; }
        public string Photo { get; set; }
        public string PhotoTimeStamp { get; set; }
        public string Ansa { get; set; }
        public string CrisisScreeningTimeStamp { get; set; }
        public string AssessmentTimeStamp { get; set; }
        public string FinancialTimeStamp { get; set; }
        public string EAndMTimeStamp { get; set; }
        public string ROSTimeStamp { get; set; }
        public string UDSTimeStamp { get; set; }
        public string FollowUpAndDisposition { get; set; }
        public string LastNursingAssessmentTimeStamp { get; set; }
        public string SubUnitId { get; set; }
        public int? BedsOccupied { get; set; }
        public int? BedsAvailable { get; set; }
    }
}
