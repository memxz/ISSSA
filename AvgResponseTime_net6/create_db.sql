CREATE DATABASE ResponseTimeDB
GO

USE ResponseTimeDB
GO

CREATE TABLE ResponseTimeDB.dbo.MockData (
	Id uniqueidentifier NOT NULL,
	[Key] nvarchar(36) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	CreateTimestamp bigint NOT NULL,
	CONSTRAINT PK_MockData PRIMARY KEY (Id)
);