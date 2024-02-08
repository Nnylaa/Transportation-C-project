CREATE TABLE [dbo].[TblVehicle] (
    [VehicleID]     INT        IDENTITY (1, 1) NOT NULL,
    [VehicleType]   NCHAR (30) NULL,
    [License Plate] NCHAR(30)        NULL,
    [Color]      NCHAR(30)        NULL,
    [DriverID] INT NULL, 
    PRIMARY KEY CLUSTERED ([VehicleID] ASC)
);

