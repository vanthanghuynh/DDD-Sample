CREATE TABLE [dbo].[Appointment]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [PatientId] UNIQUEIDENTIFIER NOT NULL, 
    [RoomId] UNIQUEIDENTIFIER NOT NULL, 
    [DoctorId] UNIQUEIDENTIFIER NOT NULL, 
    [AppointmentTypeId] UNIQUEIDENTIFIER NOT NULL, 
    [StartTime] DATETIME NULL, 
    [EndTime] DATETIME NULL, 
    [Title] NVARCHAR(50) NULL, 
    [ScheduleId] UNIQUEIDENTIFIER NOT NULL, 
    CONSTRAINT [FK_Appointment_Patient] FOREIGN KEY ([PatientId]) REFERENCES [Patient]([Id]), 
    CONSTRAINT [FK_Appointment_Room] FOREIGN KEY ([RoomId]) REFERENCES [Room]([Id]), 
    CONSTRAINT [FK_Appointment_Doctor] FOREIGN KEY ([DoctorId]) REFERENCES [Doctor]([Id]), 
    CONSTRAINT [FK_Appointment_AppointmentType] FOREIGN KEY ([AppointmentTypeId]) REFERENCES [AppointmentType]([Id]), 
    CONSTRAINT [FK_Appointment_Schedule] FOREIGN KEY ([ScheduleId]) REFERENCES [Schedule]([Id])
)
