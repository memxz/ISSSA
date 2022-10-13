/*
1. First create a database in your Microsft SQL Server. 
2. Then execute this SQL script on the database and tables will be created .
*/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persons](
	[Id] [uniqueidentifier] NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[JobTitle] [nvarchar](max) NULL,
	[YearsExperience] [int] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Persons] ADD  CONSTRAINT [PK_Persons] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO

INSERT INTO dbo.Persons (Id,FirstName,LastName,JobTitle,YearsExperience) VALUES
	 (N'6423CE6C-F6CB-4C0B-69A1-08DA1520C509',N'Jerry',N'Tan',N'Engineer',12),
	 (N'CEBFC70C-2D3E-424A-69A2-08DA1520C509',N'Hogan',N'Wong',N'Data Scientist',5),
	 (N'7266EC43-36E9-4B19-69A3-08DA1520C509',N'Jean',N'Lee',N'HR Manager',15),
	 (N'28AF1C43-990B-4294-69A4-08DA1520C509',N'Kelly',N'Lai',N'Flight Attendant',8);
