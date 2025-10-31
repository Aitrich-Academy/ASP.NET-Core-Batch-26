create database HireMeNowDB


create table Users(
Id uniqueidentifier default newid() primary key ,
FirstName varchar(50) null,
LastName varchar(50) null,
Email varchar(100) not null unique,
Gender varchar(20) null,
Location varchar(30) null,
Phone varchar(50) null,
Password varchar(50) null,
Role varchar(40) null,
About varchar(50) null,
Designation varchar(50) null,
CompanyId uniqueidentifier null,
Image varchar(100) null,
Status varchar(50) null)

alter table Users add constraint email_unique unique(email)

create table Jobs(
Id uniqueidentifier default newid() primary key,
Title varchar(30),
Description varchar(50),
Location varchar(30),
Experience varchar(100),
TypeofWorkPlace varchar(30),
Responsibilities varchar(100),
Salary varchar(50),
JobType varchar(50),
VacanciesCount int,
AppliedCount int,
CompanyId uniqueidentifier default newid(),
Status varchar(30))

alter table Jobs add CreatedBy uniqueidentifier foreign key references Users(Id)


create table Applications(
Id uniqueidentifier default newid() primary key,
UserId uniqueidentifier null,
JobId uniqueidentifier null,
AppliedDate date null,
status varchar(50) null,
foreign key(UserId) references Users(Id),
foreign key(JobId) references Jobs(Id))


insert into Users (Id,FirstName,LastName,Email,Gender,Location,Phone,Password,Role,About,Designation,CompanyId,Image,Status)
values
('9b80c5d4-5de6-4f16-acd5-26f7d392b8b9','Hanneth','CH','hannethch@gmail.com','female','Bathery','9633608124','123','Job provider','null','null','9b80c5d4-5de6-4f16-acd5-26f7d392b8b9','null','active')
insert into Users (Id,FirstName,LastName,Email,Gender,Location,Phone,Password,Role,About,Designation,CompanyId,Image,Status)
values
('6F9619FF-8B86-D011-B42D-00C04FC964FF','Asad','PS','azad@gmail.com','male','Kozhikode','123456','123','job seeker','null','null','6F9619FF-8B86-D011-B42D-00C04FC964FF','null','active')

update Users set Phone='9999999999',Location='kochi',About='Experienced .NET developer with 5+ years'
where Email='azad@gmail.com'
select * from Users
SELECT * FROM users WHERE Role='Job seeker';
SELECT * FROM users WHERE Role='Job provider';

DELETE FROM Users WHERE Email='shini@gmail.com';

INSERT INTO 
Jobs(
Title,Description,Location,Experience,TypeofWorkPlace,Responsibilities,Salary,JobType,VacanciesCount,AppliedCount,Status)
VALUES ('Dotnet Developer', 'need a senior dotnet lead developer', 'thrissur', '2', 'WFH', '500000-800000', 'need to lead a team ', 'FullTime', 50, 14, 'Active');

select * from Jobs

insert into 
Jobs(
Title,Description,Location,Experience,TypeofWorkPlace,Responsibilities,Salary,JobType,VacanciesCount,AppliedCount,Status)
values
('backend developer','need a dotnet backend developer','calicut','1','1234567890','need to lead a team','30000', 'FullTime', 50, 14, 'Active')

SELECT * FROM Jobs WHERE Title LIKE '%Dotnet%'

INSERT INTO Applications(UserId, JobId, Status, AppliedDate) VALUES ('6F9619FF-8B86-D011-B42D-00C04FC964FF', 'C4CC7E23-7518-468A-A0E1-1B86D161628A', 'Pending', '2023-10-11')

select * from Applications
select * from Users
select * from Jobs

select * from Applications a,Users u 
where a.UserId=u.Id and
u.Email='yadhu.aitrich@gmail.com'

SELECT j.Title, u.FirstName, u.Location
FROM Applications a INNER JOIN users u 
ON u.Id = a.UserId INNER JOIN Jobs j 
ON j.Id = a.JobId

UPDATE Applications SET Status='Cancelled' WHERE JobId='C4CC7E23-7518-468A-A0E1-1B86D161628A'
DELETE FROM Applications WHERE JobId='C4CC7E23-7518-468A-A0E1-1B86D161628A'


INSERT INTO Jobs
( Title, Description, Location, Experience, TypeOfWorkPlace, Salary, Responsibilities, JobType, VacanciesCount, AppliedCount, Status,CreatedBy)
VALUES
('Dotnet Developer', 'need a senior dotnet lead developer', 'thrissur', '2', 'WFH','35000','responsible to lead a team','full time','4','6','applied','6F9619FF-8B86-D011-B42D-00C04FC964FF')

delete from Jobs where id='C4CC7E23-7518-468A-A0E1-1B86D161628A'
delete from Jobs where id='9D7D5B74-6AFB-4C95-958D-9666741D3B9E'

Select j.Title,j.Description,j.Responsibilities,j.Experience,j.Location  from Jobs j,users u where u.Email='soudha.aitrich@gmail.com' and j.CreatedBy=u.Id

INSERT  INTO users
(Id,FirstName, LastName, Email, Gender, Location, Phone, Password, Role, About,Designation, CompanyId, Status, Image)
 VALUES
 ('9b80c5d4-5de6-4f16-acd5-26f7d392b8b9','Soudha', 'AM', 'soudha.aitrich@gmail.com','Female', 'Thrissur', NULL, '123', 'Jobprovider', NULL, NULL, NULL, 'Active', NULL)

 delete from Users where Id='9b80c5d4-5de6-4f16-acd5-26f7d392b8b9'

 INSERT  INTO users
(Id,FirstName, LastName, Email, Gender, Location, Phone, Password, Role, About,Designation, CompanyId, Status, Image)
 VALUES
  ('6fa50404-3754-4062-a4b0-ca333468e69a', 'yadhu', 'krishna', 'yadhu.aitrich@gmail.com', NULL, 'Thrissur', NULL, '123', 'Jobseeker', NULL, NULL, NULL, 'Active', NULL)


INSERT INTO Jobs
( Title, Description, Location, Experience, TypeOfWorkPlace, Salary, Responsibilities, JobType, VacanciesCount, AppliedCount, Status,CreatedBy)
VALUES
('Dotnet Developer', 'need a  dotnet lead developer', 'calicut', '2', 'WFH','35000','responsible to lead a team','full time','10','6','pending','9b80c5d4-5de6-4f16-acd5-26f7d392b8b9')


UPDATE Users SET
Phone = '8085499250',
Location='Kochi',
About='Experienced .NET developer with 5+ years of experience in building Enterprise applications'
WHERE email = 'yadhu.aitrich@gmail.com';

alter table users 
alter column About varchar(200) null

Select * from users where Role='Jobseeker'
Select * from users where Role='Jobprovider'