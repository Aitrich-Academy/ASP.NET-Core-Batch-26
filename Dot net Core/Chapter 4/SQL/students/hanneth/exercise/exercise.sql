create database University_Information

create table University(
UID int primary key,
name varchar(20) ,
chancellor varchar(20))

create table College(
CID int primary key,
University int  foreign key references University(UID) ,
dean int foreign key references Dean(DeanId),
name varchar(20))

create table Dean(
DeanId int primary key,
name varchar(20),
DateOfBirth datetime)

create table Department(
DID int primary key,
College int foreign key references College(CID),
Name varchar(20))

create table professor(
PID int primary key,
Department int foreign key references Department(DID),
name varchar(20))

create table course(
CourseID int primary key,
Department int foreign key references  Department(DID),
Name varchar(20))

create table Subject(
SubjectID int primary key,
Course int foreign key references Course(CourseID),
Professor int foreign key references  professor(PID),
Name varchar(20))
 
 create table Student(
 StudentID int primary key,
Department int foreign key references  Department(DID),
Name	varchar (20),
DateofEnrollment	smalldatetime,
TelephoneNumber	varchar(20))

create table Student_Registration(
Student int foreign key references  Student(StudentID),
Subject int foreign key references Subject(SubjectID))

insert into University values
(123,'Hanneth','Kader Mangad'),
(124,'Shabina','Kader Mangad')
update University set name='Kannur' where UID=123
update University set name='Calicut',chancellor='Ramesh Kumar' where UID=124

insert into College values
(221,123,311,'Hanneth'),
(222,124,311,'Shabina')

update College set name='LBS College of Engg' where CID=221
update College set name='Nehru College' where CID=222

insert into Dean values
(311,'Swapna',12/1/1990),
(312,'Athira',5/5/1991)

insert into Department values
(412,222,'Computer'),
(413,221,'Machanical')

update Department set name='Computer' where DID=412
update Department set name='Mechanical' where DID=413
select * from Department

insert into professor values
(511,412,'shabina'),
(512,413,'Hanneth')

update professor set name='Ambikasuthan Mangad' where PID=511
update professor set name='Binoy Viswan' where PID=512

insert into course values
(611,412,'BCA'),
(612,413,'BTech')
update course set name='MCA' where CourseID=611
insert into course values(613,412,'Btech CS')

insert into Subject values
(711,611,511,'Malayalam'),
(712,612,512,'Hindi')
insert into Subject values(713,613,512,'computer')

insert into Student values
(811,412,'Hanneth',12/12/22,'9633445566'),
(812,413,'Asad',12/3/23,'9911223344')

insert into Student_Registration values
(811,711),
(812,712)

select Student.Name,course.Name 
from 
Student
left join 
course
on
Student.Department=course.Department

update University set chancellor='Renuka mukerjee' where UID=124
select * from Dean


update Dean set name='Renuka Mukerjee' where DeanId=312

update Student set TelephoneNumber='1122334455' where StudentID=812

select Student.Name,College.name,course.Name,professor.name 
from
Student student,College,course,professor

select professor.name from 
professor
inner join 
course
on professor.Department=course.Department

select professor.name from 
professor
inner join 
course
on course.Name='MCA'

select professor.name from 
professor
inner join 
course
on course.CourseID=611

select course.Name 
from course 
inner join professor
on professor.name='Ambikasuthan Mangad'

select s.Department,d.Name
from Student as s
inner join Department as d
on s.Department=d.DID
order by
d.Name

select * from Department
select * from College order by name desc

select Subject.Name from Subject
inner join
course
on
course.Name='Btech CS'

select count(*) from course 
inner join Subject
on Subject.Name like '%computer%'

select Subject.Name,professor.name from Subject
inner join professor
on  Subject.Professor=professor.PID
order by Subject.Name


