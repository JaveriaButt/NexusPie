USE [master]
GO
/****** Object:  Database [SES]    Script Date: 4/19/2020 1:19:03 PM ******/
CREATE DATABASE [SES]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SES', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\SES.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SES_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\SES_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SES].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SES] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SES] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SES] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SES] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SES] SET ARITHABORT OFF 
GO
ALTER DATABASE [SES] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SES] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SES] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SES] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SES] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SES] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SES] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SES] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SES] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SES] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SES] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SES] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SES] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SES] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SES] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SES] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SES] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SES] SET RECOVERY FULL 
GO
ALTER DATABASE [SES] SET  MULTI_USER 
GO
ALTER DATABASE [SES] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SES] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SES] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SES] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'SES', N'ON'
GO
USE [SES]
GO
/****** Object:  Table [dbo].[batch_exam_info]    Script Date: 4/19/2020 1:19:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[batch_exam_info](
	[id] [bigint] NOT NULL,
	[exam_info_id] [bigint] NULL,
	[batch_semester_info_id] [bigint] NULL,
 CONSTRAINT [PK_batch_exam_info] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[batch_info]    Script Date: 4/19/2020 1:19:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[batch_info](
	[id] [bigint] NOT NULL,
	[batch_name] [nvarchar](max) NULL,
 CONSTRAINT [PK_batch_info] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[batch_semester_info]    Script Date: 4/19/2020 1:19:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[batch_semester_info](
	[id] [bigint] NOT NULL,
	[batch_session_info_id] [bigint] NULL,
	[semester_info_id] [bigint] NULL,
 CONSTRAINT [PK_batch_semester_info] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[batch_session_info]    Script Date: 4/19/2020 1:19:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[batch_session_info](
	[id] [bigint] NOT NULL,
	[dep_info_id] [bigint] NULL,
	[batch_info_id] [bigint] NULL,
	[session_info_id] [bigint] NULL,
 CONSTRAINT [PK_batch_session_info] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[department_info]    Script Date: 4/19/2020 1:19:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[department_info](
	[id] [bigint] NOT NULL,
	[dep_name] [nvarchar](max) NULL,
	[dep_hod] [nvarchar](max) NULL,
 CONSTRAINT [PK_department_info] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[exam_info]    Script Date: 4/19/2020 1:19:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[exam_info](
	[id] [bigint] NOT NULL,
	[exam_type] [nvarchar](max) NULL,
 CONSTRAINT [PK_exam_info] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[grade_info]    Script Date: 4/19/2020 1:19:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[grade_info](
	[id] [bigint] NULL,
	[marks] [nvarchar](max) NULL,
	[grade] [nvarchar](max) NULL,
	[gp] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[semester_info]    Script Date: 4/19/2020 1:19:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[semester_info](
	[id] [bigint] NOT NULL,
	[s_start_name] [nvarchar](max) NULL,
	[s_start_year] [nvarchar](max) NULL,
	[s_name] [nvarchar](max) NULL,
 CONSTRAINT [PK_semester_info] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[session_info]    Script Date: 4/19/2020 1:19:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[session_info](
	[id] [bigint] NOT NULL,
	[s_start_name] [nvarchar](max) NULL,
	[s_start_year] [nvarchar](max) NULL,
	[s_end_name] [nvarchar](max) NULL,
	[s_end_year] [nvarchar](max) NULL,
 CONSTRAINT [PK_session_info] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Settings]    Script Date: 4/19/2020 1:19:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Settings](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TypeID] [int] NULL,
	[SettingName] [varchar](50) NULL,
	[Module] [varchar](100) NULL,
	[SubModule] [varchar](100) NULL,
	[ContorlName] [varchar](100) NULL,
	[HeaderText] [varchar](100) NULL,
	[FontFamily] [varchar](50) NULL,
	[FontSize] [varchar](50) NULL,
	[FontColor] [varchar](50) NULL,
	[BackgroundColor] [varchar](50) NULL,
	[Height] [varchar](50) NULL,
	[Width] [varchar](50) NULL,
	[Margin] [varchar](50) NULL,
	[BorderBrushSize] [varchar](50) NULL,
	[BorderColor] [varchar](50) NULL,
	[SettingKey] [varchar](50) NULL,
	[SettingValue] [varchar](max) NULL,
	[ImagePath] [varchar](150) NULL,
	[IsEnable] [tinyint] NULL,
 CONSTRAINT [PK_Settings] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SettingTypes]    Script Date: 4/19/2020 1:19:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SettingTypes](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SettingType] [varchar](50) NULL,
	[AppType] [varchar](50) NULL,
 CONSTRAINT [PK_SettingTypes] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[std_result_info]    Script Date: 4/19/2020 1:19:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[std_result_info](
	[id] [bigint] NOT NULL,
	[student_info_id] [bigint] NULL,
	[gp] [nvarchar](max) NULL,
	[gpa] [nvarchar](max) NULL,
	[crh] [nvarchar](max) NULL,
	[o_marks] [nvarchar](max) NULL,
	[t_marks] [nvarchar](max) NULL,
	[batch_exam_info_id] [bigint] NULL,
 CONSTRAINT [PK_std_result_info] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[std_sub_result_info]    Script Date: 4/19/2020 1:19:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[std_sub_result_info](
	[id] [bigint] NOT NULL,
	[student_subject_info_id] [bigint] NULL,
	[s_marks] [nvarchar](max) NULL,
	[s_total_marks] [nvarchar](max) NULL,
	[batch_exam_info_id] [bigint] NULL,
 CONSTRAINT [PK_std_sub_result_info] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[student_info]    Script Date: 4/19/2020 1:19:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[student_info](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[std_name] [nvarchar](max) NULL,
	[std_fathername] [nvarchar](max) NULL,
	[std_rollno] [nvarchar](max) NULL,
	[std_regno] [nvarchar](max) NULL,
	[std_Gender] [nchar](10) NULL,
	[std_CNIC] [varchar](15) NULL,
	[std_ContactNumber] [varchar](15) NULL,
	[std_Disablity] [varchar](150) NULL,
	[std_ImagePath] [varchar](max) NULL,
	[std_Department] [varchar](150) NULL,
	[std_Batch] [varchar](150) NULL,
	[std_Note] [varchar](250) NULL,
	[std_session] [varchar](150) NULL,
	[is_freeze] [bit] NULL,
 CONSTRAINT [PK_student_info] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[student_subject_info]    Script Date: 4/19/2020 1:19:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[student_subject_info](
	[id] [bigint] NOT NULL,
	[student_info_id] [bigint] NULL,
	[subject_info_id] [bigint] NULL,
	[batch_semester_info_id] [bigint] NULL,
 CONSTRAINT [PK_student_subject_info] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[subject_info]    Script Date: 4/19/2020 1:19:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[subject_info](
	[id] [bigint] NOT NULL,
	[sub_name] [nvarchar](max) NULL,
	[sub_crh] [int] NULL,
	[sub_code] [nvarchar](max) NULL,
	[batch_semester_info_id] [bigint] NULL,
	[sub_type_info_id] [bigint] NULL,
 CONSTRAINT [PK_subject_info] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[subject_type_info]    Script Date: 4/19/2020 1:19:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[subject_type_info](
	[id] [bigint] NOT NULL,
	[sub_type] [int] NULL,
	[sub_type_name] [nvarchar](max) NULL,
 CONSTRAINT [PK_subject_type_info] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user_info]    Script Date: 4/19/2020 1:19:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user_info](
	[id] [bigint] NOT NULL,
	[username] [nvarchar](max) NULL,
	[user_fullname] [nvarchar](max) NULL,
	[user_email] [nvarchar](max) NULL,
	[user_password] [nvarchar](max) NULL,
	[user_mob] [nvarchar](max) NULL,
	[role_id] [bigint] NULL,
	[user_gender] [nvarchar](max) NULL,
 CONSTRAINT [PK_user_info] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Settings] ON 

INSERT [dbo].[Settings] ([ID], [TypeID], [SettingName], [Module], [SubModule], [ContorlName], [HeaderText], [FontFamily], [FontSize], [FontColor], [BackgroundColor], [Height], [Width], [Margin], [BorderBrushSize], [BorderColor], [SettingKey], [SettingValue], [ImagePath], [IsEnable]) VALUES (1, 1, N'MenuItem', N'HomeScreen', N'ToolbarMenu', N'btnStudent', N'Student', N'Cairo', N'20', N'Black', N'#81D3F5', N'45', N'120', N'05', N'1.5', N'White', N'MenuItemFontSize', N'20', N'\Settings\App\Images\Student.png', 1)
INSERT [dbo].[Settings] ([ID], [TypeID], [SettingName], [Module], [SubModule], [ContorlName], [HeaderText], [FontFamily], [FontSize], [FontColor], [BackgroundColor], [Height], [Width], [Margin], [BorderBrushSize], [BorderColor], [SettingKey], [SettingValue], [ImagePath], [IsEnable]) VALUES (3, 1, N'MenuItem', N'HomeScreen', N'ToolbarMenu', N'btnSubject', N'Subject', N'Cairo', N'20', N'Black', N'#81D3F5', N'45', N'110', N'05', N'1.5', N'White', N'MenuItemFontFamily', N'Cairo', N'\Settings\App\Images\Subject.png', 1)
INSERT [dbo].[Settings] ([ID], [TypeID], [SettingName], [Module], [SubModule], [ContorlName], [HeaderText], [FontFamily], [FontSize], [FontColor], [BackgroundColor], [Height], [Width], [Margin], [BorderBrushSize], [BorderColor], [SettingKey], [SettingValue], [ImagePath], [IsEnable]) VALUES (5, 1, N'MenuItem', N'HomeScreen', N'ToolbarMenu', N'btnDepartment', N'Department', N'Cairo', N'20', N'Black', N'#81D3F5', N'45', N'150', N'05', N'1.5', N'White', N'MenuItemFontColor', N'Black', N'\Settings\App\Images\Department.png', 1)
INSERT [dbo].[Settings] ([ID], [TypeID], [SettingName], [Module], [SubModule], [ContorlName], [HeaderText], [FontFamily], [FontSize], [FontColor], [BackgroundColor], [Height], [Width], [Margin], [BorderBrushSize], [BorderColor], [SettingKey], [SettingValue], [ImagePath], [IsEnable]) VALUES (6, 1, N'MenuItem', N'HomeScreen', N'ToolbarMenu', N'btnResult', N'Result', N'Cairo', N'20', N'Black', N'#81D3F5', N'45', N'120', N'05', N'1.5', N'White', N'MenuButtonColor', N'Coral', N'\Settings\App\Images\Department.png', 1)
INSERT [dbo].[Settings] ([ID], [TypeID], [SettingName], [Module], [SubModule], [ContorlName], [HeaderText], [FontFamily], [FontSize], [FontColor], [BackgroundColor], [Height], [Width], [Margin], [BorderBrushSize], [BorderColor], [SettingKey], [SettingValue], [ImagePath], [IsEnable]) VALUES (7, 1, N'MenuItem', N'HomeScreen', N'ToolbarMenu', N'btnPrint', N'Print', N'Cairo', N'20', N'Black', N'#81D3F5', N'45', N'100', N'05', N'1.5', N'White', N'MenuButtonWidth', N'150', N'\Settings\App\Images\Print.png', 1)
INSERT [dbo].[Settings] ([ID], [TypeID], [SettingName], [Module], [SubModule], [ContorlName], [HeaderText], [FontFamily], [FontSize], [FontColor], [BackgroundColor], [Height], [Width], [Margin], [BorderBrushSize], [BorderColor], [SettingKey], [SettingValue], [ImagePath], [IsEnable]) VALUES (8, 1, N'MenuItem', N'HomeScreen', N'ToolbarMenu', N'btnInformation', N'Information', N'Cairo', N'20', N'Black', N'#81D3F5', N'45', N'150', N'05', N'1.5', N'White', N'MenuButtonHeight', N'50', N'\Settings\App\Images\Information.png', 1)
INSERT [dbo].[Settings] ([ID], [TypeID], [SettingName], [Module], [SubModule], [ContorlName], [HeaderText], [FontFamily], [FontSize], [FontColor], [BackgroundColor], [Height], [Width], [Margin], [BorderBrushSize], [BorderColor], [SettingKey], [SettingValue], [ImagePath], [IsEnable]) VALUES (9, 1, N'MenuItem', N'HomeScreen', N'ToolbarMenu', N'btnSettings', N'Setting', N'Cairo', N'20', N'Black', N'#81D3F5', N'45', N'120', N'05', N'1.5', N'White', N'MenuButtonMargin', N'05', N'\Settings\App\Images\Settings.png', 1)
INSERT [dbo].[Settings] ([ID], [TypeID], [SettingName], [Module], [SubModule], [ContorlName], [HeaderText], [FontFamily], [FontSize], [FontColor], [BackgroundColor], [Height], [Width], [Margin], [BorderBrushSize], [BorderColor], [SettingKey], [SettingValue], [ImagePath], [IsEnable]) VALUES (26, 1, N'MenuItem', N'HomeScreen', N'ToolbarMenu', N'btnHelp', N'Help', N'Cairo', N'20', N'Black', N'#81D3F5', N'45', N'100', N'05', N'1.5', N'White', N'MenuButtonMargin', N'05', N'\Settings\App\Images\Help.png', 1)
INSERT [dbo].[Settings] ([ID], [TypeID], [SettingName], [Module], [SubModule], [ContorlName], [HeaderText], [FontFamily], [FontSize], [FontColor], [BackgroundColor], [Height], [Width], [Margin], [BorderBrushSize], [BorderColor], [SettingKey], [SettingValue], [ImagePath], [IsEnable]) VALUES (27, 1, N'ButtonBackGround', N'ButtonBackGround', N'ButtonBackGround', N'Button', NULL, NULL, NULL, NULL, N'#00A699', NULL, NULL, NULL, NULL, NULL, N'ButtonBackGround', N'#00A699', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Settings] OFF
SET IDENTITY_INSERT [dbo].[SettingTypes] ON 

INSERT [dbo].[SettingTypes] ([ID], [SettingType], [AppType]) VALUES (1, N'AppDesign', N'1000')
INSERT [dbo].[SettingTypes] ([ID], [SettingType], [AppType]) VALUES (2, N'AppContents', N'1000')
SET IDENTITY_INSERT [dbo].[SettingTypes] OFF
SET IDENTITY_INSERT [dbo].[student_info] ON 

INSERT [dbo].[student_info] ([id], [std_name], [std_fathername], [std_rollno], [std_regno], [std_Gender], [std_CNIC], [std_ContactNumber], [std_Disablity], [std_ImagePath], [std_Department], [std_Batch], [std_Note], [std_session], [is_freeze]) VALUES (1, N'Tahir Rehman', N'Haibut UR Rehman', N'200', N'CS200', N'Male      ', N'1330256471347', N'0599138039', N'N/A', N'pack://application:,,,/Settings/App/Images/StudentImage.png', N'-- Select Department --', N'-- Select Batch --', N'', N'-- Select Session --', NULL)
SET IDENTITY_INSERT [dbo].[student_info] OFF
ALTER TABLE [dbo].[batch_exam_info]  WITH CHECK ADD  CONSTRAINT [FK_batch_exam_info_batch_semester_info] FOREIGN KEY([batch_semester_info_id])
REFERENCES [dbo].[batch_semester_info] ([id])
GO
ALTER TABLE [dbo].[batch_exam_info] CHECK CONSTRAINT [FK_batch_exam_info_batch_semester_info]
GO
ALTER TABLE [dbo].[batch_exam_info]  WITH CHECK ADD  CONSTRAINT [FK_batch_exam_info_exam_info] FOREIGN KEY([exam_info_id])
REFERENCES [dbo].[exam_info] ([id])
GO
ALTER TABLE [dbo].[batch_exam_info] CHECK CONSTRAINT [FK_batch_exam_info_exam_info]
GO
ALTER TABLE [dbo].[batch_semester_info]  WITH CHECK ADD  CONSTRAINT [FK_batch_semester_info_batch_session_info] FOREIGN KEY([batch_session_info_id])
REFERENCES [dbo].[batch_session_info] ([id])
GO
ALTER TABLE [dbo].[batch_semester_info] CHECK CONSTRAINT [FK_batch_semester_info_batch_session_info]
GO
ALTER TABLE [dbo].[batch_semester_info]  WITH CHECK ADD  CONSTRAINT [FK_batch_semester_info_semester_info] FOREIGN KEY([semester_info_id])
REFERENCES [dbo].[semester_info] ([id])
GO
ALTER TABLE [dbo].[batch_semester_info] CHECK CONSTRAINT [FK_batch_semester_info_semester_info]
GO
ALTER TABLE [dbo].[batch_session_info]  WITH CHECK ADD  CONSTRAINT [FK_batch_session_info_batch_info] FOREIGN KEY([batch_info_id])
REFERENCES [dbo].[batch_info] ([id])
GO
ALTER TABLE [dbo].[batch_session_info] CHECK CONSTRAINT [FK_batch_session_info_batch_info]
GO
ALTER TABLE [dbo].[batch_session_info]  WITH CHECK ADD  CONSTRAINT [FK_batch_session_info_department_info] FOREIGN KEY([dep_info_id])
REFERENCES [dbo].[department_info] ([id])
GO
ALTER TABLE [dbo].[batch_session_info] CHECK CONSTRAINT [FK_batch_session_info_department_info]
GO
ALTER TABLE [dbo].[batch_session_info]  WITH CHECK ADD  CONSTRAINT [FK_batch_session_info_session_info] FOREIGN KEY([session_info_id])
REFERENCES [dbo].[session_info] ([id])
GO
ALTER TABLE [dbo].[batch_session_info] CHECK CONSTRAINT [FK_batch_session_info_session_info]
GO
ALTER TABLE [dbo].[std_sub_result_info]  WITH CHECK ADD  CONSTRAINT [FK_std_sub_result_info_student_subject_info] FOREIGN KEY([student_subject_info_id])
REFERENCES [dbo].[student_subject_info] ([id])
GO
ALTER TABLE [dbo].[std_sub_result_info] CHECK CONSTRAINT [FK_std_sub_result_info_student_subject_info]
GO
ALTER TABLE [dbo].[student_subject_info]  WITH CHECK ADD  CONSTRAINT [FK_student_subject_info_batch_semester_info] FOREIGN KEY([batch_semester_info_id])
REFERENCES [dbo].[batch_semester_info] ([id])
GO
ALTER TABLE [dbo].[student_subject_info] CHECK CONSTRAINT [FK_student_subject_info_batch_semester_info]
GO
ALTER TABLE [dbo].[student_subject_info]  WITH CHECK ADD  CONSTRAINT [FK_student_subject_info_student_info] FOREIGN KEY([student_info_id])
REFERENCES [dbo].[student_info] ([id])
GO
ALTER TABLE [dbo].[student_subject_info] CHECK CONSTRAINT [FK_student_subject_info_student_info]
GO
ALTER TABLE [dbo].[student_subject_info]  WITH CHECK ADD  CONSTRAINT [FK_student_subject_info_subject_info] FOREIGN KEY([subject_info_id])
REFERENCES [dbo].[subject_info] ([id])
GO
ALTER TABLE [dbo].[student_subject_info] CHECK CONSTRAINT [FK_student_subject_info_subject_info]
GO
ALTER TABLE [dbo].[subject_info]  WITH CHECK ADD  CONSTRAINT [FK_subject_info_subject_type_info] FOREIGN KEY([sub_type_info_id])
REFERENCES [dbo].[subject_type_info] ([id])
GO
ALTER TABLE [dbo].[subject_info] CHECK CONSTRAINT [FK_subject_info_subject_type_info]
GO
/****** Object:  StoredProcedure [dbo].[HomeMenuControlSetting]    Script Date: 4/19/2020 1:19:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

-- Exec HomeMenuControlSetting
CREATE PROCEDURE  [dbo].[HomeMenuControlSetting]
	 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
select * from Settings where SettingName ='MenuItem'   for XML path('ControlsSetting'),ROOT('AppDesign')
END
GO
USE [master]
GO
ALTER DATABASE [SES] SET  READ_WRITE 
GO
