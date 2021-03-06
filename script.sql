USE [master]
GO
/****** Object:  Database [school]    Script Date: 5/30/2021 7:04:26 PM ******/
CREATE DATABASE [school]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'school', FILENAME = N'E:\New folder\MSSQL15.MSSQLSERVER\MSSQL\DATA\school.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'school_log', FILENAME = N'E:\New folder\MSSQL15.MSSQLSERVER\MSSQL\DATA\school_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [school] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [school].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [school] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [school] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [school] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [school] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [school] SET ARITHABORT OFF 
GO
ALTER DATABASE [school] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [school] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [school] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [school] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [school] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [school] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [school] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [school] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [school] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [school] SET  DISABLE_BROKER 
GO
ALTER DATABASE [school] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [school] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [school] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [school] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [school] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [school] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [school] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [school] SET RECOVERY FULL 
GO
ALTER DATABASE [school] SET  MULTI_USER 
GO
ALTER DATABASE [school] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [school] SET DB_CHAINING OFF 
GO
ALTER DATABASE [school] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [school] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [school] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [school] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'school', N'ON'
GO
ALTER DATABASE [school] SET QUERY_STORE = OFF
GO
USE [school]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 5/30/2021 7:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[AdminID] [int] IDENTITY(1,1) NOT NULL,
	[PersonID] [int] NOT NULL,
 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 
(
	[AdminID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Attendance]    Script Date: 5/30/2021 7:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Attendance](
	[AttendanceID] [int] IDENTITY(1,1) NOT NULL,
	[AttendanceTypeID] [int] NOT NULL,
	[ProfSubjID] [int] NOT NULL,
	[StudentID] [int] NOT NULL,
	[SemesterID] [int] NOT NULL,
	[Date] [date] NOT NULL,
	[Motivated] [bit] NOT NULL,
 CONSTRAINT [PK_Attendance_1] PRIMARY KEY CLUSTERED 
(
	[AttendanceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AttendanceType]    Script Date: 5/30/2021 7:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AttendanceType](
	[AttendanceTypeID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Attendance] PRIMARY KEY CLUSTERED 
(
	[AttendanceTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AverageGrade]    Script Date: 5/30/2021 7:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AverageGrade](
	[AverageID] [int] IDENTITY(1,1) NOT NULL,
	[StudentID] [int] NOT NULL,
	[ProfSubjID] [int] NOT NULL,
	[SemesterID] [int] NOT NULL,
	[Grade] [int] NOT NULL,
 CONSTRAINT [PK_AverageGrade] PRIMARY KEY CLUSTERED 
(
	[AverageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Class]    Script Date: 5/30/2021 7:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Class](
	[ClassID] [int] IDENTITY(1,1) NOT NULL,
	[Letter] [nvarchar](5) NOT NULL,
	[Year_specID] [int] NOT NULL,
	[HeadMasterID] [int] NOT NULL,
 CONSTRAINT [PK_Class] PRIMARY KEY CLUSTERED 
(
	[ClassID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Document]    Script Date: 5/30/2021 7:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Document](
	[DocumentID] [int] IDENTITY(1,1) NOT NULL,
	[Link] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_Document] PRIMARY KEY CLUSTERED 
(
	[DocumentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Document_ClassProfSubj]    Script Date: 5/30/2021 7:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Document_ClassProfSubj](
	[ProfSubjClassID] [int] NOT NULL,
	[DocumentID] [int] NOT NULL,
 CONSTRAINT [PK_Document_ClassProfSubj_1] PRIMARY KEY CLUSTERED 
(
	[ProfSubjClassID] ASC,
	[DocumentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Grade]    Script Date: 5/30/2021 7:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grade](
	[GradeID] [int] IDENTITY(1,1) NOT NULL,
	[ProfSubjID] [int] NOT NULL,
	[StudentID] [int] NOT NULL,
	[SemesterID] [int] NOT NULL,
	[Number] [float] NOT NULL,
	[Final] [bit] NOT NULL,
	[Date] [date] NOT NULL,
 CONSTRAINT [PK_Grade] PRIMARY KEY CLUSTERED 
(
	[GradeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 5/30/2021 7:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[PersonID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[PersonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prof_Subj_Class]    Script Date: 5/30/2021 7:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prof_Subj_Class](
	[ProfSubjClassID] [int] IDENTITY(1,1) NOT NULL,
	[ProfSubjID] [int] NOT NULL,
	[YearSpecID] [int] NOT NULL,
	[Hours_per_week] [int] NOT NULL,
	[FinalTestRequired] [bit] NOT NULL,
 CONSTRAINT [PK_Prof_Subj_Class_1] PRIMARY KEY CLUSTERED 
(
	[ProfSubjClassID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Professor]    Script Date: 5/30/2021 7:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Professor](
	[ProfessorID] [int] IDENTITY(1,1) NOT NULL,
	[PersonID] [int] NOT NULL,
 CONSTRAINT [PK_Professor] PRIMARY KEY CLUSTERED 
(
	[ProfessorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Professor_Subject]    Script Date: 5/30/2021 7:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Professor_Subject](
	[ProfSubjID] [int] IDENTITY(1,1) NOT NULL,
	[ProfessorID] [int] NOT NULL,
	[SubjectID] [int] NOT NULL,
 CONSTRAINT [PK_Professor_Subject] PRIMARY KEY CLUSTERED 
(
	[ProfSubjID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Registration]    Script Date: 5/30/2021 7:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Registration](
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Registration] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Semester]    Script Date: 5/30/2021 7:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Semester](
	[SemesterID] [int] IDENTITY(1,1) NOT NULL,
	[Number] [int] NOT NULL,
 CONSTRAINT [PK_Semester] PRIMARY KEY CLUSTERED 
(
	[SemesterID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Specialization]    Script Date: 5/30/2021 7:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Specialization](
	[SecializationId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Specialization] PRIMARY KEY CLUSTERED 
(
	[SecializationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 5/30/2021 7:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[StudentID] [int] IDENTITY(1,1) NOT NULL,
	[PersonID] [int] NOT NULL,
	[ClassID] [int] NOT NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subject]    Script Date: 5/30/2021 7:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subject](
	[SubjectID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Subject] PRIMARY KEY CLUSTERED 
(
	[SubjectID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Year]    Script Date: 5/30/2021 7:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Year](
	[YearID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Year] PRIMARY KEY CLUSTERED 
(
	[YearID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Year_Specializaion]    Script Date: 5/30/2021 7:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Year_Specializaion](
	[Year_specID] [int] IDENTITY(1,1) NOT NULL,
	[YearID] [int] NOT NULL,
	[SepcializationId] [int] NOT NULL,
 CONSTRAINT [PK_Year_Specializaion] PRIMARY KEY CLUSTERED 
(
	[Year_specID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Attendance] ADD  CONSTRAINT [DF_Attendance_Motivated]  DEFAULT ((0)) FOR [Motivated]
GO
ALTER TABLE [dbo].[Admin]  WITH CHECK ADD  CONSTRAINT [FK__Admin__PersonID] FOREIGN KEY([PersonID])
REFERENCES [dbo].[Person] ([PersonID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Admin] CHECK CONSTRAINT [FK__Admin__PersonID]
GO
ALTER TABLE [dbo].[Attendance]  WITH CHECK ADD  CONSTRAINT [FK_Attendance_AttendanceType] FOREIGN KEY([AttendanceTypeID])
REFERENCES [dbo].[AttendanceType] ([AttendanceTypeID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Attendance] CHECK CONSTRAINT [FK_Attendance_AttendanceType]
GO
ALTER TABLE [dbo].[Attendance]  WITH CHECK ADD  CONSTRAINT [FK_Attendance_Professor_Subject] FOREIGN KEY([ProfSubjID])
REFERENCES [dbo].[Professor_Subject] ([ProfSubjID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Attendance] CHECK CONSTRAINT [FK_Attendance_Professor_Subject]
GO
ALTER TABLE [dbo].[Attendance]  WITH CHECK ADD  CONSTRAINT [FK_Attendance_Semester] FOREIGN KEY([SemesterID])
REFERENCES [dbo].[Semester] ([SemesterID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Attendance] CHECK CONSTRAINT [FK_Attendance_Semester]
GO
ALTER TABLE [dbo].[Attendance]  WITH CHECK ADD  CONSTRAINT [FK_Attendance_Student] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Student] ([StudentID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Attendance] CHECK CONSTRAINT [FK_Attendance_Student]
GO
ALTER TABLE [dbo].[AverageGrade]  WITH CHECK ADD  CONSTRAINT [FK_AverageGrade_Professor_Subject] FOREIGN KEY([ProfSubjID])
REFERENCES [dbo].[Professor_Subject] ([ProfSubjID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AverageGrade] CHECK CONSTRAINT [FK_AverageGrade_Professor_Subject]
GO
ALTER TABLE [dbo].[AverageGrade]  WITH CHECK ADD  CONSTRAINT [FK_AverageGrade_Semester] FOREIGN KEY([SemesterID])
REFERENCES [dbo].[Semester] ([SemesterID])
GO
ALTER TABLE [dbo].[AverageGrade] CHECK CONSTRAINT [FK_AverageGrade_Semester]
GO
ALTER TABLE [dbo].[AverageGrade]  WITH CHECK ADD  CONSTRAINT [FK_AverageGrade_Student] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Student] ([StudentID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AverageGrade] CHECK CONSTRAINT [FK_AverageGrade_Student]
GO
ALTER TABLE [dbo].[Class]  WITH CHECK ADD  CONSTRAINT [FK_Class_HeadMaster] FOREIGN KEY([HeadMasterID])
REFERENCES [dbo].[Professor] ([ProfessorID])
GO
ALTER TABLE [dbo].[Class] CHECK CONSTRAINT [FK_Class_HeadMaster]
GO
ALTER TABLE [dbo].[Class]  WITH CHECK ADD  CONSTRAINT [FK_Class_Year_Specializaion] FOREIGN KEY([Year_specID])
REFERENCES [dbo].[Year_Specializaion] ([Year_specID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Class] CHECK CONSTRAINT [FK_Class_Year_Specializaion]
GO
ALTER TABLE [dbo].[Document_ClassProfSubj]  WITH CHECK ADD  CONSTRAINT [FK_Document_ClassProfSubj_Document] FOREIGN KEY([DocumentID])
REFERENCES [dbo].[Document] ([DocumentID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Document_ClassProfSubj] CHECK CONSTRAINT [FK_Document_ClassProfSubj_Document]
GO
ALTER TABLE [dbo].[Document_ClassProfSubj]  WITH CHECK ADD  CONSTRAINT [FK_Document_ClassProfSubj_Prof_Subj_Class] FOREIGN KEY([ProfSubjClassID])
REFERENCES [dbo].[Prof_Subj_Class] ([ProfSubjClassID])
GO
ALTER TABLE [dbo].[Document_ClassProfSubj] CHECK CONSTRAINT [FK_Document_ClassProfSubj_Prof_Subj_Class]
GO
ALTER TABLE [dbo].[Grade]  WITH CHECK ADD  CONSTRAINT [FK_Grade_Prof_Subj_Class] FOREIGN KEY([ProfSubjID])
REFERENCES [dbo].[Professor_Subject] ([ProfSubjID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Grade] CHECK CONSTRAINT [FK_Grade_Prof_Subj_Class]
GO
ALTER TABLE [dbo].[Grade]  WITH CHECK ADD  CONSTRAINT [FK_Grade_Semester] FOREIGN KEY([SemesterID])
REFERENCES [dbo].[Semester] ([SemesterID])
GO
ALTER TABLE [dbo].[Grade] CHECK CONSTRAINT [FK_Grade_Semester]
GO
ALTER TABLE [dbo].[Grade]  WITH CHECK ADD  CONSTRAINT [FK_Grade_Student] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Student] ([StudentID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Grade] CHECK CONSTRAINT [FK_Grade_Student]
GO
ALTER TABLE [dbo].[Person]  WITH CHECK ADD  CONSTRAINT [FK_Person_Registration] FOREIGN KEY([Username])
REFERENCES [dbo].[Registration] ([Username])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Person] CHECK CONSTRAINT [FK_Person_Registration]
GO
ALTER TABLE [dbo].[Prof_Subj_Class]  WITH CHECK ADD  CONSTRAINT [FK_Prof_Subj_Class_Professor_Subject] FOREIGN KEY([ProfSubjID])
REFERENCES [dbo].[Professor_Subject] ([ProfSubjID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Prof_Subj_Class] CHECK CONSTRAINT [FK_Prof_Subj_Class_Professor_Subject]
GO
ALTER TABLE [dbo].[Prof_Subj_Class]  WITH CHECK ADD  CONSTRAINT [FK_Prof_Subj_Class_Year_Specializaion] FOREIGN KEY([YearSpecID])
REFERENCES [dbo].[Year_Specializaion] ([Year_specID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Prof_Subj_Class] CHECK CONSTRAINT [FK_Prof_Subj_Class_Year_Specializaion]
GO
ALTER TABLE [dbo].[Professor]  WITH CHECK ADD  CONSTRAINT [FK__Professor__PersonId] FOREIGN KEY([PersonID])
REFERENCES [dbo].[Person] ([PersonID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Professor] CHECK CONSTRAINT [FK__Professor__PersonId]
GO
ALTER TABLE [dbo].[Professor_Subject]  WITH CHECK ADD  CONSTRAINT [FK_Professor_Subject_Subject] FOREIGN KEY([SubjectID])
REFERENCES [dbo].[Subject] ([SubjectID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Professor_Subject] CHECK CONSTRAINT [FK_Professor_Subject_Subject]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK__Student__ClassID] FOREIGN KEY([ClassID])
REFERENCES [dbo].[Class] ([ClassID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK__Student__ClassID]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK__Student__PersonID] FOREIGN KEY([PersonID])
REFERENCES [dbo].[Person] ([PersonID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK__Student__PersonID]
GO
ALTER TABLE [dbo].[Year_Specializaion]  WITH CHECK ADD  CONSTRAINT [FK_Year_Specializaion_Specialization] FOREIGN KEY([SepcializationId])
REFERENCES [dbo].[Specialization] ([SecializationId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Year_Specializaion] CHECK CONSTRAINT [FK_Year_Specializaion_Specialization]
GO
ALTER TABLE [dbo].[Year_Specializaion]  WITH CHECK ADD  CONSTRAINT [FK_Year_Specializaion_Year] FOREIGN KEY([YearID])
REFERENCES [dbo].[Year] ([YearID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Year_Specializaion] CHECK CONSTRAINT [FK_Year_Specializaion_Year]
GO
/****** Object:  StoredProcedure [dbo].[AddAttendance]    Script Date: 5/30/2021 7:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AddAttendance]
@profID int,
@studentID int,
@date date,
@subjectID int,
@semesterId int,
@type nvarchar(50)
AS
BEGIN
	declare @profsubjID int
	set @profsubjID = (select Professor_Subject.ProfSubjID from Professor_Subject 
	inner join Professor on Professor_Subject.ProfessorID = Professor.ProfessorID
	inner join Subject on Professor_Subject.SubjectID = Subject.SubjectID
	where Professor.ProfessorID = @profID and Subject.SubjectID = @subjectID);

	declare @typeID int
	set @typeID = (select AttendanceType.AttendanceTypeID from AttendanceType where AttendanceType.Name = @type);

	insert into Attendance(AttendanceTypeID, ProfSubjID, StudentID, SemesterID, Date)
	values (@typeID, @profsubjID, @studentID, @semesterId, @date);
END
GO
/****** Object:  StoredProcedure [dbo].[AddAverageGrade]    Script Date: 5/30/2021 7:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AddAverageGrade] 
	@studentID int,
	@profID int,
	@subjectID int,
	@semesterID int,
	@grade int

AS
BEGIN
	declare @profsubjID int
	set @profsubjID = (select Professor_Subject.ProfSubjID from Professor_Subject 
	inner join Professor on Professor_Subject.ProfessorID = Professor.ProfessorID
	inner join Subject on Professor_Subject.SubjectID = Subject.SubjectID
	where Professor.ProfessorID = @profID and Subject.SubjectID = @subjectID);

	insert into AverageGrade(StudentID, ProfSubjID, SemesterID, Grade)
	values (@studentID, @profsubjID, @semesterID, @grade);
END
GO
/****** Object:  StoredProcedure [dbo].[AddGrade]    Script Date: 5/30/2021 7:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AddGrade]
@profID int,
@studentID int,
@grade int,
@date date,
@subjectID int,
@semesterId int,
@final bit
AS
BEGIN
	declare @profsubjID int
	set @profsubjID = (select Professor_Subject.ProfSubjID from Professor_Subject 
	inner join Professor on Professor_Subject.ProfessorID = Professor.ProfessorID
	inner join Subject on Professor_Subject.SubjectID = Subject.SubjectID
	where Professor.ProfessorID = @profID and Subject.SubjectID = @subjectID);

	insert into Grade(ProfSubjID, StudentID, SemesterID, Number, Final, Date)
	values (@profsubjID, @studentID, @semesterId, @grade, @final, @date);
END
GO
/****** Object:  StoredProcedure [dbo].[AddProfessor]    Script Date: 5/30/2021 7:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AddProfessor]
	@username nvarchar(50),
	@password nvarchar(50),
	@first_name nvarchar(50),
	@last_name nvarchar(50)
AS
BEGIN
	insert into Registration(Username, Password)
	values(@username, @password);

	insert into Person(FirstName, LastName, Username)
	values(@first_name, @last_name, @username)

	insert into Professor(PersonID)
	values (SCOPE_IDENTITY())
END
GO
/****** Object:  StoredProcedure [dbo].[AddProfessorSubject]    Script Date: 5/30/2021 7:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AddProfessorSubject]
	@subjectID int,
	@profID int
AS
BEGIN
	insert into Professor_Subject(ProfessorID, SubjectID) values (@profID, @subjectID);
END
GO
/****** Object:  StoredProcedure [dbo].[AddStudent]    Script Date: 5/30/2021 7:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AddStudent]
@username nvarchar(50),
@password nvarchar(50),
@first_name nvarchar(50),
@last_name nvarchar(50),
@class_name nvarchar(50),
@class_number nvarchar(50),
@specialization nvarchar(50)
AS
BEGIN
    declare @classID int

	set @classID = (select Class.ClassID from Class 
	inner join Year_Specializaion on Year_Specializaion.Year_specID = Class.Year_specID
	inner join Year on Year.YearID = Year_Specializaion.YearID
	inner join Specialization on Specialization.SecializationId = Year_Specializaion.SepcializationId
	where year.Name = @class_number and Class.Letter = @class_name and Specialization.Name = @specialization);


	insert into Registration(Username, Password)
	values(@username, @password)

	insert into Person(FirstName, LastName, Username)
	values(@first_name, @last_name, @username)

	
	insert into Student(PersonID, ClassID)
	values (SCOPE_IDENTITY(), @classID)
END
GO
/****** Object:  StoredProcedure [dbo].[AddSubject]    Script Date: 5/30/2021 7:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AddSubject] 
	@subject_name nvarchar(50)
AS
BEGIN
	insert into Subject values (@subject_name);
END
GO
/****** Object:  StoredProcedure [dbo].[AddSubjectToYearSpecialization]    Script Date: 5/30/2021 7:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AddSubjectToYearSpecialization]
	@year_id int,
	@spec_id int,
	@subject_id int,
	@prof_id int,
	@nr_houres int,
	@final bit
AS
BEGIN
	declare @year_spec_id int
	set @year_spec_id = (select Year_Specializaion.Year_specID from Year_Specializaion
	inner join  Year on Year_Specializaion.YearID = Year.YearID 
	inner join Specialization on Year_Specializaion.SepcializationId = Specialization.SecializationId
	where Year.YearID = @year_id and Specialization.SecializationId = @spec_id);

	declare @subj_prof_id int
	set @subj_prof_id = (select Professor_Subject.ProfSubjID from Professor_Subject 
	inner join Subject on Subject.SubjectID = Professor_Subject.SubjectID
	inner join Professor on Professor.ProfessorID = Professor_Subject.ProfessorID
	where Subject.SubjectID = @subject_id and Professor.ProfessorID = @prof_id);

	insert into Prof_Subj_Class(ProfSubjID, YearSpecID, Hours_per_week, FinalTestRequired) 
	values (@subj_prof_id, @year_spec_id, @nr_houres, @final);
END
GO
/****** Object:  StoredProcedure [dbo].[AllGradesForStudent]    Script Date: 5/30/2021 7:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AllGradesForStudent]
	@studentID int
AS
BEGIN
	select Grade.Number, Subject.SubjectID, Subject.Name as subject, Grade.Date, Semester.SemesterID,
	Semester.Number as semester, Grade.Final 
	from Grade 
	inner join Professor_Subject on Professor_Subject.ProfSubjID = Grade.ProfSubjID
	inner join Subject on Subject.SubjectID = Professor_Subject.SubjectID
	inner join Semester on Grade.SemesterID = Semester.SemesterID
	where grade.StudentID = @studentID;
END
GO
/****** Object:  StoredProcedure [dbo].[AllSubjectsForProfessor]    Script Date: 5/30/2021 7:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AllSubjectsForProfessor]
@profID int
AS
BEGIN
	select Subject.SubjectID, Subject.Name from Subject inner join Professor_Subject on Professor_Subject.SubjectID = Subject.SubjectID
	inner join Professor on Professor.ProfessorID = Professor_Subject.ProfessorID where Professor.ProfessorID = @profID;
END
GO
/****** Object:  StoredProcedure [dbo].[AttendanceForStudent]    Script Date: 5/30/2021 7:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AttendanceForStudent]
	@studentID int
AS
BEGIN
	select Subject.SubjectID, Subject.Name as subject, Attendance.Date, AttendanceType.Name, 
	Semester.SemesterID, Semester.Number as semester, Attendance.Motivated, Professor_Subject.ProfessorID
	from Attendance 
	inner join AttendanceType on Attendance.AttendanceTypeID = AttendanceType.AttendanceTypeID
	inner join Professor_Subject on Professor_Subject.ProfSubjID = Attendance.ProfSubjID
	inner join Subject on Subject.SubjectID = Professor_Subject.SubjectID
	inner join Semester on Attendance.SemesterID = Semester.SemesterID
	where Attendance.StudentID = @studentID;
END
GO
/****** Object:  StoredProcedure [dbo].[AverageGradeSem]    Script Date: 5/30/2021 7:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AverageGradeSem]
	@studentID int,
	@sem int
AS
BEGIN
	select AverageGrade.Grade, Subject.Name as subject
	from AverageGrade 
	inner join Professor_Subject on Professor_Subject.ProfSubjID = AverageGrade.ProfSubjID
	inner join Subject on Subject.SubjectID = Professor_Subject.SubjectID
	inner join Semester on AverageGrade.SemesterID = Semester.SemesterID
	where AverageGrade.StudentID = @studentID and  Semester.Number = @sem;
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteGrade]    Script Date: 5/30/2021 7:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DeleteGrade] 
@profID int,
@studentID int,
@grade int,
@date date,
@subjectID int,
@semesterId int,
@final bit
AS
BEGIN
	declare @profsubjID int
	set @profsubjID = (select Professor_Subject.ProfSubjID from Professor_Subject 
	inner join Professor on Professor_Subject.ProfessorID = Professor.ProfessorID
	inner join Subject on Professor_Subject.SubjectID = Subject.SubjectID
	where Professor.ProfessorID = @profID and Subject.SubjectID = @subjectID);

	delete from Grade where Grade.ProfSubjID = @profsubjID and Grade.Date = @date and 
	SemesterID = @semesterId and Grade.Number = @grade and Grade.StudentID = @studentID
	and Grade.Final = @final;
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteLinkProfessorSubject]    Script Date: 5/30/2021 7:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DeleteLinkProfessorSubject] 
	@subjectID int,
	@profID int
AS
BEGIN
	delete from Professor_Subject where ProfessorID = @profID and SubjectID = @subjectID
END
GO
/****** Object:  StoredProcedure [dbo].[DeletePerson]    Script Date: 5/30/2021 7:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DeletePerson]
	@username nvarchar(50)
AS
BEGIN
	delete from Registration where Registration.Username = @username;
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteSubject]    Script Date: 5/30/2021 7:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DeleteSubject]
@subject_name nvarchar(50)
AS
BEGIN
	delete from Subject where Subject.Name = @subject_name;
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllProfessorSubject]    Script Date: 5/30/2021 7:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetAllProfessorSubject]
AS
BEGIN
	select Person.FirstName, Person.LastName, Subject.Name from Person inner join Professor on Person.PersonID = Professor.PersonID
	inner join Professor_Subject on Professor_Subject.ProfessorID = Professor.ProfessorID
	inner join Subject on Subject.SubjectID = Professor_Subject.SubjectID;
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllSubjects]    Script Date: 5/30/2021 7:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetAllSubjects]
AS
BEGIN
	select Subject.SubjectID, Subject.Name from Subject;
END
GO
/****** Object:  StoredProcedure [dbo].[GetAverageGrade]    Script Date: 5/30/2021 7:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetAverageGrade]
	@studentID int,
	@classID int,
	@profID int,
	@subjectID int,
	@semesterID int
AS
BEGIN
	declare @year_specID int
	set @year_specID = (select Year_Specializaion.Year_specID from Year_Specializaion
	inner join Class on Class.Year_specID = Year_Specializaion.Year_specID
	where Class.ClassID = @classID);

	declare @hasFinal bit

	set @hasFinal = (select Prof_Subj_Class.FinalTestRequired from Subject
	inner join Professor_Subject on Professor_Subject.SubjectID = Subject.SubjectID
	inner join Professor on Professor.ProfessorID = Professor_Subject.ProfessorID
	inner join Prof_Subj_Class on Prof_Subj_Class.ProfSubjID = Professor_Subject.ProfSubjID
	where Professor.ProfessorID = @profID and Subject.SubjectID = @subjectID and Prof_Subj_Class.YearSpecID = @year_specID);

	declare @profsubjID int
	set @profsubjID = (select Professor_Subject.ProfSubjID from Professor_Subject 
	inner join Professor on Professor_Subject.ProfessorID = Professor.ProfessorID
	inner join Subject on Professor_Subject.SubjectID = Subject.SubjectID
	where Professor.ProfessorID = @profID and Subject.SubjectID = @subjectID);

	if @hasFinal = 0
	begin
		declare @avg float
		set @avg = (select avg(Grade.Number) from Grade 
		where Grade.ProfSubjID = @profsubjID and Grade.StudentID = @studentID and Grade.SemesterID=@semesterID);
		if @avg is null
		begin
			select cast(-2 as float)
			return
		end
		else
		begin
		select @avg
		end
	end
	else
	begin
		declare @aux float
		set @aux = (select avg(Grade.Number) from Grade 
		where Grade.ProfSubjID = @profsubjID and Grade.StudentID = @studentID and Grade.Final = 0 and Grade.SemesterID=@semesterID);

		if @aux is null
		begin
			select cast(-2 as float);
			return
		end

		if (select Grade.Number from Grade 
		where Grade.ProfSubjID = @profsubjID and Grade.StudentID = @studentID and Grade.Final = 1 and 
		Grade.SemesterID=@semesterID) is null
		begin
			select cast(-1 as float);
			return
		end

		select (Grade.Number + 3 * @aux) / 4 from Grade 
		where Grade.ProfSubjID = @profsubjID and Grade.StudentID = @studentID and Grade.Final = 1 and
		Grade.SemesterID=@semesterID;

	end
END
GO
/****** Object:  StoredProcedure [dbo].[GetAveragesForStudent]    Script Date: 5/30/2021 7:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetAveragesForStudent]
	@studentID int
AS
BEGIN
	select AverageGrade.Grade, Subject.SubjectID, Subject.Name as subject, Semester.SemesterID,
	Semester.Number as semester
	from AverageGrade 
	inner join Professor_Subject on Professor_Subject.ProfSubjID = AverageGrade.ProfSubjID
	inner join Subject on Subject.SubjectID = Professor_Subject.SubjectID
	inner join Semester on AverageGrade.SemesterID = Semester.SemesterID
	where AverageGrade.StudentID = @studentID;
END
GO
/****** Object:  StoredProcedure [dbo].[GetClasses]    Script Date: 5/30/2021 7:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetClasses]
AS
BEGIN
	select Class.ClassID, Year.Name as YearName, Class.Letter, Specialization.Name as SpecializationName
	from Class 
	inner join Year_Specializaion on Class.Year_specID = Year_Specializaion.Year_specID
	inner join Year on Year.YearID = Year_Specializaion.YearID
	inner join Specialization on Specialization.SecializationId = Year_Specializaion.SepcializationId
END
GO
/****** Object:  StoredProcedure [dbo].[GetProfessorByUsername]    Script Date: 5/30/2021 7:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetProfessorByUsername]
	@username nvarchar(50)
AS
BEGIN
	select Registration.Password, Person.PersonID, Person.FirstName, Person.LastName, Person.Username

	from Person inner join Registration on Person.Username = Registration.Username
	inner join Professor on Professor.PersonID = Person.PersonID
	where Registration.Username = @username;
END
GO
/****** Object:  StoredProcedure [dbo].[GetProfessors]    Script Date: 5/30/2021 7:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetProfessors]
AS
BEGIN
	select Registration.Password, Person.PersonID, Person.FirstName, Person.LastName, Person.Username

	from Person inner join Registration on Person.Username = Registration.Username
	inner join Professor on Professor.PersonID = Person.PersonID;
END
GO
/****** Object:  StoredProcedure [dbo].[GetSpecializationForClass]    Script Date: 5/30/2021 7:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetSpecializationForClass]
@year_name nvarchar(50),
@letter nvarchar(50)
AS
BEGIN
	select Specialization.Name from Specialization 
	inner join Year_Specializaion on Year_Specializaion.SepcializationId = Specialization.SecializationId
	inner join Year on Year.YearID = Year_Specializaion.YearID and Year.Name = @year_name
	inner join Class on Class.Letter = @letter and class.Year_specID = Year_Specializaion.Year_specID;
END
GO
/****** Object:  StoredProcedure [dbo].[GetStudentByUsername]    Script Date: 5/30/2021 7:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetStudentByUsername]
	@username nvarchar(50)
AS
BEGIN
	select Registration.Password, Person.PersonID, Person.FirstName, Person.LastName, Person.Username, Student.ClassID, Student.StudentID, 
	Specialization.Name as spec, Year.Name as y, Class.Letter

	from Student inner join Person on Student.PersonID = Person.PersonID
	inner join Registration on Person.Username = Registration.Username
	inner join Class on Student.ClassID = Class.ClassID
	inner join Year_Specializaion on Year_Specializaion.Year_specID = Class.Year_specID
	inner join Specialization on Specialization.SecializationId = Year_Specializaion.SepcializationId
	inner join Year on Year.YearID = Year_Specializaion.YearID
	where Registration.Username = @username;
END
GO
/****** Object:  StoredProcedure [dbo].[GetStudents]    Script Date: 5/30/2021 7:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetStudents]
AS
BEGIN
	select Registration.Password, Person.PersonID, Person.FirstName, Person.LastName, Person.Username, Student.ClassID, Student.StudentID, 
	Specialization.Name as spec, Year.Name as y, Class.Letter

	from Student inner join Person on Student.PersonID = Person.PersonID
	inner join Registration on Person.Username = Registration.Username
	inner join Class on Student.ClassID = Class.ClassID
	inner join Year_Specializaion on Year_Specializaion.Year_specID = Class.Year_specID
	inner join Specialization on Specialization.SecializationId = Year_Specializaion.SepcializationId
	inner join Year on Year.YearID = Year_Specializaion.YearID;

END
GO
/****** Object:  StoredProcedure [dbo].[MotivateAttendance]    Script Date: 5/30/2021 7:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[MotivateAttendance]
@profID int,
@studentID int,
@date date,
@subjectID int,
@semesterId int
AS
BEGIN
	declare @profsubjID int
	set @profsubjID = (select Professor_Subject.ProfSubjID from Professor_Subject 
	inner join Professor on Professor_Subject.ProfessorID = Professor.ProfessorID
	inner join Subject on Professor_Subject.SubjectID = Subject.SubjectID
	where Professor.ProfessorID = @profID and Subject.SubjectID = @subjectID);

	update Attendance set Attendance.Motivated = 1 where Attendance.ProfSubjID = @profsubjID
	and Attendance.Date = @date and Attendance.StudentID = @studentID and Attendance.SemesterID = @semesterId;
END
GO
/****** Object:  StoredProcedure [dbo].[SetHeadMaster]    Script Date: 5/30/2021 7:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SetHeadMaster]
	@class_id int,
	@prof_id int
AS
BEGIN
	Update Class set HeadMasterID = @prof_id where ClassID = @class_id;
END
GO
/****** Object:  StoredProcedure [dbo].[StudentsByProfessorSubject]    Script Date: 5/30/2021 7:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[StudentsByProfessorSubject] 
	@profID int,
	@subjectID int
AS
BEGIN
	declare @prof_subjID int
	set @prof_subjID = (select Professor_Subject.ProfSubjID from Professor_Subject
	inner join Professor on Professor_Subject.ProfessorID = Professor.ProfessorID
	inner join Subject on Subject.SubjectID = Professor_Subject.SubjectID
	where Professor.ProfessorID = @profID and Subject.SubjectID = @subjectID);

	select Registration.Password, Person.PersonID, Person.FirstName, Person.LastName, Person.Username, 
	Student.ClassID, Student.StudentID, Specialization.Name as spec, Year.Name as y, Class.Letter

	from Student inner join Person on Student.PersonID = Person.PersonID
	inner join Registration on Person.Username = Registration.Username
	inner join Class on Student.ClassID = Class.ClassID
	inner join Year_Specializaion on Year_Specializaion.Year_specID = Class.Year_specID
	inner join Specialization on Specialization.SecializationId = Year_Specializaion.SepcializationId
	inner join Year on Year.YearID = Year_Specializaion.YearID
	inner join Prof_Subj_Class on Prof_Subj_Class.YearSpecID = Year_Specializaion.Year_specID
	where Prof_Subj_Class.ProfSubjID = @prof_subjID;
END
GO
/****** Object:  StoredProcedure [dbo].[SubjectsWithFinals]    Script Date: 5/30/2021 7:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SubjectsWithFinals]
	@studentId int
AS
BEGIN
	Select Subject.SubjectID, Subject.Name as subject, Professor.ProfessorID from
	Student inner join Class on Student.ClassID = Class.ClassID
	inner join Year_Specializaion on Year_Specializaion.Year_specID = Class.Year_specID
	inner join Prof_Subj_Class on Prof_Subj_Class.YearSpecID = Year_Specializaion.Year_specID
	inner join Professor_Subject on Prof_Subj_Class.ProfSubjID = Professor_Subject.ProfSubjID
	inner join Professor on Professor.ProfessorID = Professor_Subject.ProfessorID
	inner join Subject on Subject.SubjectID = Professor_Subject.SubjectID
	where Student.StudentID = @studentId;
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateProfessor]    Script Date: 5/30/2021 7:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UpdateProfessor]
	@personId int,
	@username nvarchar(50),
	@password nvarchar(50),
	@first_name nvarchar(50),
	@last_name nvarchar(50)
AS
BEGIN
	update Registration set Username = @username from Registration inner join Person on Registration.Username = Person.Username
	where Person.PersonID = @personID;
	Update Person set LastName = @last_name, FirstName = @first_name where Person.PersonID = @personID;
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateStudent]    Script Date: 5/30/2021 7:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UpdateStudent]
	@personID int,
	@studentID int,
	@password nvarchar(50),
	@firstName nvarchar(50),
	@lastName nvarchar(50),
	@username nvarchar(50),
	@classID int
AS
BEGIN
	Update Student set ClassID = @classID where Student.StudentID = @studentID;
	Update Registration set Username = @username, Password = @password from Registration inner join Person on Registration.Username = Person.Username
	where Person.PersonID = @personID;
	Update Person set LastName = @lastName, FirstName = @firstName where Person.PersonID = @personID;
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateSubject]    Script Date: 5/30/2021 7:04:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UpdateSubject] 
	@subjectId nvarchar(50),
	@name nvarchar(50)
AS
BEGIN
	update Subject set Name = @name where Subject.SubjectID = @subjectId;
END
GO
USE [master]
GO
ALTER DATABASE [school] SET  READ_WRITE 
GO
