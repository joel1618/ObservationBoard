namespace ObservationBoard.Sql.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public class Configuration : IDatabaseInitializer<ObservationBoardEntities>
    {
        public void InitializeDatabase(ObservationBoardEntities context)
        {
            using (context = new ObservationBoardEntities())
            {
                if (!context.Database.Exists())
                {
                    context.Database.Create();
                    context.Database.Connection.Open();
                    context.ObservationBoards.AddOrUpdate(x => x.Id,
                        new ObservationBoard()
                        {
                            Id = 174711,
                            Client = "123456-BH, LA",
                            OpenedTimeStamp = DateTime.Now,
                            AssignedBed = 10,
                            Status = "Urgent",
                            AccompaniedBy = "Walk-In",
                            DemographicTimeStamp = DateTime.Now,
                            GeneralConsentTimeStamp = DateTime.Now,
                            Photo = null,
                            PhotoTimeStamp = DateTime.Now,
                            Ansa = null,
                            CrisisScreeningTimeStamp = DateTime.Now,
                            AssessmentTimeStamp = DateTime.Now,
                            FinancialTimeStamp = DateTime.Now,
                            EAndMTimeStamp = null,
                            ROSTimeStamp = DateTime.Now,
                            UDSTimeStamp = DateTime.Now,
                            FollowUpAndDisposition = "",
                            LastNursingAssessmentTimeStamp = DateTime.Now,
                            BedsAvailable = 10,
                            BedsOccupied = 4
                        });

                    context.ObservationBoards.AddOrUpdate(x => x.Id,
                        new ObservationBoard()
                        {
                            Id = 110945,
                            Client = "234567-TT, ZZ",
                            OpenedTimeStamp = DateTime.Now,
                            AssignedBed = 14,
                            Status = "Urgent",
                            AccompaniedBy = "Walk-In",
                            DemographicTimeStamp = DateTime.Now,
                            GeneralConsentTimeStamp = DateTime.Now,
                            Photo = null,
                            PhotoTimeStamp = DateTime.Now,
                            Ansa = null,
                            CrisisScreeningTimeStamp = DateTime.Now,
                            AssessmentTimeStamp = DateTime.Now,
                            FinancialTimeStamp = null,
                            EAndMTimeStamp = DateTime.Now,
                            ROSTimeStamp = DateTime.Now,
                            UDSTimeStamp = DateTime.Now,
                            FollowUpAndDisposition = "",
                            LastNursingAssessmentTimeStamp = DateTime.Now,
                            BedsAvailable = 10,
                            BedsOccupied = 4
                        });

                    context.ObservationBoards.AddOrUpdate(x => x.Id,
                        new ObservationBoard()
                        {
                            Id = 276316,
                            Client = "345678-AT, WE",
                            OpenedTimeStamp = DateTime.Now,
                            AssignedBed = 15,
                            Status = "Emergency",
                            AccompaniedBy = null,
                            DemographicTimeStamp = DateTime.Now,
                            GeneralConsentTimeStamp = DateTime.Now,
                            Photo = null,
                            PhotoTimeStamp = DateTime.Now,
                            Ansa = null,
                            CrisisScreeningTimeStamp = null,
                            AssessmentTimeStamp = DateTime.Now,
                            FinancialTimeStamp = DateTime.Now,
                            EAndMTimeStamp = DateTime.Now,
                            ROSTimeStamp = DateTime.Now,
                            UDSTimeStamp = null,
                            FollowUpAndDisposition = "",
                            LastNursingAssessmentTimeStamp = DateTime.Now,
                            BedsAvailable = 10,
                            BedsOccupied = 4
                        });

                    context.ObservationBoards.AddOrUpdate(x => x.Id,
                        new ObservationBoard()
                        {
                            Id = 230433,
                            Client = "456789-FV, SA",
                            OpenedTimeStamp = DateTime.Now,
                            AssignedBed = 16,
                            Status = "Urgent",
                            AccompaniedBy = null,
                            DemographicTimeStamp = DateTime.Now,
                            GeneralConsentTimeStamp = DateTime.Now,
                            Photo = null,
                            PhotoTimeStamp = DateTime.Now,
                            Ansa = null,
                            CrisisScreeningTimeStamp = DateTime.Now,
                            AssessmentTimeStamp = DateTime.Now,
                            FinancialTimeStamp = DateTime.Now,
                            EAndMTimeStamp = null,
                            ROSTimeStamp = null,
                            UDSTimeStamp = null,
                            FollowUpAndDisposition = "",
                            LastNursingAssessmentTimeStamp = null,
                            BedsAvailable = 10,
                            BedsOccupied = 4
                        });
                    context.SaveChanges();
                    context.Database.Connection.Close();
                }
            }
        }
    }
}
