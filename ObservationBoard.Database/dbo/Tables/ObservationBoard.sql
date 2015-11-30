﻿CREATE TABLE [dbo].[ObservationBoard]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Client] NVARCHAR(50) NULL, 
    [OpenedTimeStamp] DATETIME NULL, 
    [AssignedBed] INT NULL, 
    [Status] NVARCHAR(50) NULL, 
    [AccompaniedBy] NVARCHAR(50) NULL, 
    [DemographicTimeStamp] DATETIME NULL, 
    [GeneralConsentTimeStamp] DATETIME NULL, 
    [Photo] NVARCHAR(50) NULL, 
    [PhotoTimeStamp] DATETIME NULL, 
    [Ansa] NVARCHAR(50) NULL, 
    [CrisisScreeningTimeStamp] DATETIME NULL, 
    [AssessmentTimeStamp] DATETIME NULL, 
    [FinancialTimeStamp] DATETIME NULL, 
    [EAndMTimeStamp] DATETIME NULL, 
    [ROSTimeStamp] DATETIME NULL, 
    [UDSTimeStamp] DATETIME NULL, 
    [FollowUpAndDisposition] NVARCHAR(50) NULL, 
    [LastNursingAssessmentTimeStamp] DATETIME NULL, 
    [SubUnitId] NVARCHAR(50) NULL, 
    [BedsOccupied] INT NULL, 
    [BedsAvailable] INT NULL, 
    [ss] NCHAR(10) NULL
)
