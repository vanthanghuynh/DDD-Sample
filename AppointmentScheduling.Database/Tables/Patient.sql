CREATE TABLE [dbo].[Patient]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Gender] INT NOT NULL, 
    [AnimalTypeId] UNIQUEIDENTIFIER NOT NULL, 
    [ClientId] UNIQUEIDENTIFIER NOT NULL, 
    [Species] NVARCHAR(50) NULL, 
    [Breed] NVARCHAR(50) NULL, 
    CONSTRAINT [FK_Patient_Client] FOREIGN KEY ([ClientId]) REFERENCES [Client]([Id]), 
    CONSTRAINT [FK_Patient_AnimalType] FOREIGN KEY ([AnimalTypeId]) REFERENCES [AnimalType]([Id])
)
