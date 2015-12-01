using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ObservationBoard.Models
{
    public class ObservationBoard
    {
        public int Id { get; set; }
        public string Client { get; set; }
        public DateTime? OpenedTimeStamp { get; set; }
        public int? AssignedBed { get; set; }
        public string Status { get; set; }
        public string AccompaniedBy { get; set; }
        public DateTime? DemographicTimeStamp { get; set; }
        public DateTime? GeneralConsentTimeStamp { get; set; }
        public string Photo { get; set; }
        public DateTime? PhotoTimeStamp { get; set; }
        public string Ansa { get; set; }
        public DateTime? CrisisScreeningTimeStamp { get; set; }
        public DateTime? AssessmentTimeStamp { get; set; }
        public DateTime? FinancialTimeStamp { get; set; }
        public DateTime? EAndMTimeStamp { get; set; }
        public DateTime? ROSTimeStamp { get; set; }
        public DateTime? UDSTimeStamp { get; set; }
        public string FollowUpAndDisposition { get; set; }
        public DateTime? LastNursingAssessmentTimeStamp { get; set; }
        public string SubUnitId { get; set; }
        public int? BedsOccupied { get; set; }
        public int? BedsAvailable { get; set; }

    }
}