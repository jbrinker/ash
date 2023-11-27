CREATE TABLE [dbo].[ExemptPay](
	[ExempPayID] [int] IDENTITY(1,1) NOT NULL,
	[PersonID] [int] NOT NULL,
	[AnnualSalary] [decimal](10, 2) NOT NULL,
CONSTRAINT [PK_ExemptPay] PRIMARY KEY CLUSTERED
GO

CREATE TABLE [dbo].[Expenses](
	[ExpensesID] [int] IDENTITY(1,1) NOT NULL,
	[PersonID] [int] NOT NULL,
	[MaxExpenseAmount] [decimal](10, 2) NOT NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[NonExemptPay](
	[NonExemptPayID] [int] IDENTITY(1,1) NOT NULL,
	[PersonID] [int] NOT NULL,
	[PayPerHour] [decimal](5, 2) NOT NULL,
 CONSTRAINT [PK_NonExemptPay] PRIMARY KEY CLUSTERED 
(
	[NonExemptPayID] ASC
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Persons](
	[PersonID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](30) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[Address1] [varchar](100) NOT NULL
) ON [PRIMARY]
GO