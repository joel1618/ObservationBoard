//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ObservationBoard
{
    using System;
    using System.Collections.Generic;
    
    public partial class ObservationBoard
    {
        public int Id { get; set; }
        public string Client { get; set; }
        public Nullable<System.DateTime> OpenedTimeStamp { get; set; }
        public Nullable<int> AssignedBed { get; set; }
        public string Status { get; set; }
        public string AccompaniedBy { get; set; }
        public Nullable<System.DateTime> DemographicTimeStamp { get; set; }
        public Nullable<System.DateTime> GeneralConsentTimeStamp { get; set; }
        public string Photo { get; set; }
        public Nullable<System.DateTime> PhotoTimeStamp { get; set; }
        public string Ansa { get; set; }
        public Nullable<System.DateTime> CrisisScreeningTimeStamp { get; set; }
        public Nullable<System.DateTime> AssessmentTimeStamp { get; set; }
        public Nullable<System.DateTime> FinancialTimeStamp { get; set; }
        public Nullable<System.DateTime> EAndMTimeStamp { get; set; }
        public Nullable<System.DateTime> ROSTimeStamp { get; set; }
        public Nullable<System.DateTime> UDSTimeStamp { get; set; }
        public string FollowUpAndDisposition { get; set; }
        public Nullable<System.DateTime> LastNursingAssessmentTimeStamp { get; set; }
        public string SubUnitId { get; set; }
        public Nullable<int> BedsOccupied { get; set; }
        public Nullable<int> BedsAvailable { get; set; }
    }
}
