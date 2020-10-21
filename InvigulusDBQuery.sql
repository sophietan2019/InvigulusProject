USE master
GO

/****** Object:  Database InvigulusDB     ******/
IF DB_ID('InvigulusDB') IS NOT NULL
	DROP DATABASE InvigulusDB
GO

CREATE DATABASE InvigulusDB
GO 

USE InvigulusDB
GO


-- Create ExamAdministrator table

IF EXISTS(SELECT 1 FROM sys.tables WHERE OBJECT_ID = OBJECT_ID('ExamAdministrator'))
BEGIN;
    DROP TABLE [ExamAdministrator];
END;
GO

create table ExamAdministrator
(
	ExaminerID int IDENTITY(1,1) Primary Key not null,
	FirstName varchar(50) not null,
	LastName varchar(50) not null,
	ExaminerEmail varchar(50) not null
)

insert into ExamAdministrator(FirstName, LastName, ExaminerEmail)
values 
('Sophie', 'Tan', 'sophie@sait.ca'),
('Lisa', 'S', 'lisa@sait.ca'),
('Elvis', 'Presley', 'elvis.presley@hounddog.com'),
('Bob', 'Proctor', 'bob123@fakemail.com'),
('Joe', 'Shmoe', 'joe876@hotmail.com')


--create Exam table

IF EXISTS(SELECT 1 FROM sys.tables WHERE OBJECT_ID = OBJECT_ID('Exam'))
BEGIN;
    DROP TABLE [Exam];
END;
GO
create table Exam
(
	ExamID int IDENTITY(101,1) Primary Key not null,
	ExaminerID int Foreign Key references ExamAdministrator(ExaminerID) not null,
	ExamMaxDuration time not null,		
	MaxAllowedAttemptsPerPerson int not null,
	ExamStartDate date not null,
	ExamStartTime time not null,
	ExamEndDate date not null,
	ExamEndTime time not null,
	CHECK (MaxAllowedAttemptsPerPerson>0),
	CHECK (ExamEndDate >= ExamStartDate),
	
)

insert into Exam(ExaminerID, ExamMaxDuration, MaxAllowedAttemptsPerPerson, ExamStartDate, ExamStartTime, 
ExamEndDate, ExamEndTime)
values 
(1,'02:00:00', 4, '2020-10-01', '07:00:00', '2020-11-05', '21:00'),
(1, '03:00:00', 3, '2020-09-01', '09:00:00', '2020-12-31', '10:00'),
(1,'02:00:00', 5, '2020-10-01', '07:00:00', '2020-11-05', '21:00'),
(1, '03:00:00', 3, '2020-09-01', '09:00:00', '2020-12-31', '10:00'),
(2, '04:00:00', 6, '2020-08-01', '08:00:00', '2020-11-04', '08:00'),
(2, '04:00:00', 3, '2020-08-01', '08:00:00', '2020-11-04', '08:00'),
(2, '04:00:00', 3, '2020-08-01', '08:00:00', '2020-11-04', '08:00'),
(3, '01:00:00', 1, '2020-08-01', '09:00:00', '2021-11-04', '08:00'),
(3, '01:00:00', 1, '2020-08-01', '09:00:00', '2021-11-04', '08:00'),
(3, '01:00:00', 1, '2020-08-01', '09:00:00', '2021-11-04', '08:00')

--create Examinee table
IF EXISTS(SELECT 1 FROM sys.tables WHERE OBJECT_ID = OBJECT_ID('Examinee'))
BEGIN;
    DROP TABLE [Examinee];
END;
GO
create table Examinee
(
	ExamineeID int IDENTITY(1,1) Primary Key not null,
	FirstName varchar(50) not null,
	LastName varchar(50) not null,
	ExamineeEmail varchar(50) not null,
	StreetAddress varchar(100) not null,
	City varchar(50) not null,
	Province varchar(50) not null,
	PostalCode varchar(10) not null,
	PhotoURL varchar(1500) not null UNIQUE
)

insert into Examinee(FirstName, LastName, ExamineeEmail, StreetAddress, City, Province,
PostalCode, PhotoURL)
values 
('John', 'Craig', 'john@gmail.com', '24 Start St.', 'Calgary', 'AB', 'T2L 8Z9', 
'https://images.unsplash.com/photo-1500648767791-00dcc994a43e?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=634&q=80
'),
('Jane', 'Russell', 'jane@gmail.com', '8887 Rode Dr.', 'Calgary', 'AB', 'T27 9Y4', 
'https://images.unsplash.com/photo-1494790108377-be9c29b29330?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=634&q=80'),
('Mohsen', 'Zlarg', 'turkeylover@hotmail.com', '22849853 Centre St.', 'Calgary', 'AB', 'T8K 9S9',
'https://www.ucalgary.ca/sharp/files/sharp/media_crop/193/public/mohsen-zirrahi_0.jpg'),
('Elvis', 'Presley', 'elvis001@inmail.com', '188 Falconridge Bay', 'Vancouver', 'BC', 'Y7F 0B2',
'https://images.unsplash.com/photo-1528892952291-009c663ce843?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=592&q=80')

--create ExamTaken table
IF EXISTS(SELECT 1 FROM sys.tables WHERE OBJECT_ID = OBJECT_ID('ExamTaken'))
BEGIN;
    DROP TABLE [ExamTaken];
END;
GO
create table ExamTaken
(
	ExamID int Foreign Key references Exam(ExamID) not null,
	ExamineeID int Foreign Key references Examinee(ExamineeID) not null,
	RecordingID int  not null,
	LocationID int not null,
	SubmissionTime smalldatetime not null,
	Score float not null,
	ConfidenceScore float not null,
	Primary Key (ExamID, ExamineeID),
	CHECK (Score >=0)
)
insert into ExamTaken(ExamID, ExamineeID, RecordingID, LocationID, SubmissionTime, Score, ConfidenceScore)
values 
(101, 1, 1, 1, '2021-10-2 15:30:00', 90, 78.22),
(101, 2, 1, 1, '2021-10-2 15:30:00', 30, 88.22),
(101, 3, 1, 1, '2021-10-2 15:30:00', 30, 88.22),
(102, 1, 2, 2, '2020-09-6 18:30:00', 99, 40.55),
(102, 2, 2, 2, '2020-09-6 18:30:00', 99, 40.55),
(102, 3, 4, 2, '2020-09-6 18:30:00', 99, 40.55),
(103, 1, 1, 2, '2020-09-6 18:30:00', 67, 69.55),
(103, 2, 3, 2, '2020-09-3 22:13:00', 45, 90.08),
(103, 3, 4, 3, '2020-09-3 22:45:00', 78, 56.35),
(104, 1, 4, 3, '2020-09-3 22:45:00', 78, 56.35),
(104, 2, 4, 3, '2020-09-3 22:45:00', 78, 56.35),
(104, 3, 4, 3, '2020-09-3 22:45:00', 78, 56.35),
(105, 1, 4, 3, '2020-09-3 22:45:00', 78, 56.35),
(105, 2, 4, 3, '2020-09-3 22:45:00', 78, 56.35),
(105, 3, 4, 3, '2020-09-3 22:45:00', 78, 56.35),
(106, 1, 4, 3, '2020-09-3 22:45:00', 78, 56.35),
(106, 2, 4, 3, '2020-09-3 22:45:00', 78, 56.35),
(106, 3, 4, 3, '2020-09-3 22:45:00', 78, 56.35)











