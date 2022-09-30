USE[EmployeeDB]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 9/30/2022 11:37:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](

[EmployeeID][bigint] IDENTITY(1, 1) NOT NULL,

[EmployeeName] [varchar](1000) NULL,
	[Department] [varchar](1000) NULL,
	[MailID] [varchar](1000) NULL,
	[DOJ] [datetime] NULL
) ON[PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Employees] ON
GO
INSERT [dbo].[Employees] ([EmployeeID], [EmployeeName], [Department], [MailID], [DOJ]) VALUES(1, N'Sam', N'Finance', N'sam123@gmail.com', CAST(N'2020-05-12T00:00:00.000' AS DateTime))
GO
INSERT[dbo].[Employees] ([EmployeeID], [EmployeeName], [Department], [MailID], [DOJ]) VALUES(2, N'Bob', N'IT', N'bob123@gmail.com', CAST(N'2020-08-20T00:00:00.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Employees] OFF
GO

