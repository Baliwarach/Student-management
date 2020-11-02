USE [StudentDB]
GO
/****** Object:  Table [dbo].[Courses]    Script Date: 11/2/2020 1:55:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Courses](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CourseName] [varchar](50) NOT NULL,
	[Description] [varchar](100) NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Courses] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hostels]    Script Date: 11/2/2020 1:55:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hostels](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[HostelName] [varchar](50) NOT NULL,
	[Address] [varchar](200) NULL,
	[Capacity] [int] NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Hostels] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 11/2/2020 1:55:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [varchar](100) NOT NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentEnrollment]    Script Date: 11/2/2020 1:55:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentEnrollment](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[StudentID] [int] NOT NULL,
	[CourseID] [int] NOT NULL,
	[EnrolledOn] [datetime] NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_StudentEnrollment] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 11/2/2020 1:55:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Address] [varchar](100) NULL,
	[HostelID] [int] NOT NULL,
	[Gender] [char](7) NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 11/2/2020 1:55:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](100) NOT NULL,
	[Password] [varchar](100) NOT NULL,
	[RoleID] [int] NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Courses] ON 
GO
INSERT [dbo].[Courses] ([ID], [CourseName], [Description], [IsActive]) VALUES (1, N'Computer Architecture', N'Computer Architecture', 1)
GO
INSERT [dbo].[Courses] ([ID], [CourseName], [Description], [IsActive]) VALUES (2, N'Machine Learning', N'Machine Learning', 1)
GO
INSERT [dbo].[Courses] ([ID], [CourseName], [Description], [IsActive]) VALUES (3, N'Python', N'Python', 1)
GO
SET IDENTITY_INSERT [dbo].[Courses] OFF
GO
SET IDENTITY_INSERT [dbo].[Hostels] ON 
GO
INSERT [dbo].[Hostels] ([ID], [HostelName], [Address], [Capacity], [IsActive]) VALUES (1, N'Hostel A', N'Location 1', 20, 1)
GO
INSERT [dbo].[Hostels] ([ID], [HostelName], [Address], [Capacity], [IsActive]) VALUES (2, N'Hostel B', N'Location 2', 20, 1)
GO
INSERT [dbo].[Hostels] ([ID], [HostelName], [Address], [Capacity], [IsActive]) VALUES (3, N'Hostel C', N'Location 3', 20, 1)
GO
INSERT [dbo].[Hostels] ([ID], [HostelName], [Address], [Capacity], [IsActive]) VALUES (4, N'Hostel D', N'Location 4', 20, 1)
GO
SET IDENTITY_INSERT [dbo].[Hostels] OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 
GO
INSERT [dbo].[Roles] ([ID], [RoleName], [IsActive]) VALUES (1, N'Admin', 1)
GO
INSERT [dbo].[Roles] ([ID], [RoleName], [IsActive]) VALUES (2, N'User', 1)
GO
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
SET IDENTITY_INSERT [dbo].[StudentEnrollment] ON 
GO
INSERT [dbo].[StudentEnrollment] ([ID], [StudentID], [CourseID], [EnrolledOn], [IsActive]) VALUES (1, 1, 1, CAST(N'2020-10-29T15:05:47.790' AS DateTime), 1)
GO
INSERT [dbo].[StudentEnrollment] ([ID], [StudentID], [CourseID], [EnrolledOn], [IsActive]) VALUES (2, 1, 2, CAST(N'2020-10-29T15:23:26.247' AS DateTime), 1)
GO
INSERT [dbo].[StudentEnrollment] ([ID], [StudentID], [CourseID], [EnrolledOn], [IsActive]) VALUES (1004, 1, 3, CAST(N'2020-11-01T22:36:20.757' AS DateTime), 1)
GO
INSERT [dbo].[StudentEnrollment] ([ID], [StudentID], [CourseID], [EnrolledOn], [IsActive]) VALUES (1017, 2, 2, CAST(N'2020-11-01T23:03:19.633' AS DateTime), 1)
GO
INSERT [dbo].[StudentEnrollment] ([ID], [StudentID], [CourseID], [EnrolledOn], [IsActive]) VALUES (1018, 2, 3, CAST(N'2020-11-01T23:03:19.637' AS DateTime), 1)
GO
SET IDENTITY_INSERT [dbo].[StudentEnrollment] OFF
GO
SET IDENTITY_INSERT [dbo].[Students] ON 
GO
INSERT [dbo].[Students] ([ID], [Name], [Address], [HostelID], [Gender], [IsActive]) VALUES (1, N'Akshay', N'Address 1', 1, N'Male   ', 1)
GO
INSERT [dbo].[Students] ([ID], [Name], [Address], [HostelID], [Gender], [IsActive]) VALUES (2, N'Test', N'Test', 1, N'Male   ', 1)
GO
SET IDENTITY_INSERT [dbo].[Students] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 
GO
INSERT [dbo].[Users] ([ID], [UserName], [Password], [RoleID], [Email], [IsActive]) VALUES (1, N'admin', N'admin', 1, N'admin@gmail.com', 1)
GO
INSERT [dbo].[Users] ([ID], [UserName], [Password], [RoleID], [Email], [IsActive]) VALUES (2, N'visitor', N'visitor', 2, N'visitor@gmail.com', 1)
GO
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[StudentEnrollment]  WITH CHECK ADD  CONSTRAINT [FK_StudentEnrollment_Courses] FOREIGN KEY([CourseID])
REFERENCES [dbo].[Courses] ([ID])
GO
ALTER TABLE [dbo].[StudentEnrollment] CHECK CONSTRAINT [FK_StudentEnrollment_Courses]
GO
ALTER TABLE [dbo].[StudentEnrollment]  WITH CHECK ADD  CONSTRAINT [FK_StudentEnrollment_Students] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Students] ([ID])
GO
ALTER TABLE [dbo].[StudentEnrollment] CHECK CONSTRAINT [FK_StudentEnrollment_Students]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Hostels] FOREIGN KEY([HostelID])
REFERENCES [dbo].[Hostels] ([ID])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Hostels]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Roles] FOREIGN KEY([ID])
REFERENCES [dbo].[Roles] ([ID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Roles]
GO
