CREATE TABLE [dbo].[AppointmentType]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NULL, 
    [Code] NVARCHAR(50) NULL, 
    [Duration] INT NULL
)
