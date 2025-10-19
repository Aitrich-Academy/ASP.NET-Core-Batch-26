create database University_Information

create table University(
UID int identity(101,1) primary key,
Name varchar(20) not null,
Chancellor varchar(20) null)

create table College(
CID int identity(1001,1) primary key,
University int foreign key references university(UID),
Dean int foreign key references Dean(DeanID),
Name varchar(20) not null)

create table Dean(
DeanID int identity(201,1) primary key,
Name varchar(20) not null,
DateOfBirth datetime not null)

create table Department(
DID int identity(2001,1) primary key,
College int foreign key references college(CID),
Name varchar(20) not null)

create table Professor(
PID int identity(1,1) primary key,
Department int foreign key references Department(DID),
Name varchar(20) not null)

create table Course(
CourseID int identity(501,1) primary key,
Department int foreign key references Department(DID),
Name varchar(20) not null)

create table Subject(
SubjectID int identity(001,1) primary key,
Course int foreign key references Course(CourseID),
Professor int foreign key references Professor(PID),
Name varchar(20) not null)

create table Student(
StudentID int identity(10000,1) primary key,
Department int foreign key references Department(DID),
Name varchar(20) not null,
DateOfEnrollement smallDateTime null,
TelephoneNumber varchar(20) null)

create table Student_Registration(
Student int foreign key references Student(StudentID),
Subject int foreign key references Subject(SubjectID))

select * from subject

drop table University
drop table College
drop table Dean
drop table Department
drop table Professor
drop table Course
drop table Subject
drop table Student
drop table Student_Registration

select * from University
select * from dean
select * from college
select * from Department
select * from professor
select * from course
select * from subject
select * from student
select * from student_registration



insert into University (Name,Chancellor) values
('MG University','Governor'),
('Delhi University','Vice-President'),
('Kerala University','Governor'),
('Calicut University','Governor')

insert into College(University,Dean,Name) values
(101,204,'Chinmaya Vidhya peet'),
(101,205,'Maharajas'),
(103,206,'Keralavarma college')

insert into Dean(name,DateOfBirth) values 
('Dr. Bismi ','1980-10-10'),
('Dr. Binu  ','1990-05-02'),
('Dr. Sabu ','1988-12-12')
('Renuka Sharma','1998-10-10')

insert into Department(College,name) values
(1003,'Science'),
(1003,'maths'),
(1003,'Computer'),
(1004,'psycology')

insert into Professor(Department,name) values(
(2001,'Alice'),
(2002,'Joseph'),
(2001,'Miya'),
(2004,'Rohit'),
(2003,'Jithin')

insert into course(department,name) values
(2001,'Bsc Science'),
(2001,'Marine technology'),
(2002,'Bsc Maths'),
(2003,'BCA'),
(2003,'MCA')

insert into subject(course,professor,name) values 
(501,1,'Zoology'),
(502,3,'Marine science'),
(504,5,'C++'),
(503,2,'Maths')
(504,4,'JAVA')
(504,5,'Computer'),
(505,5,'Computer')

insert into student(Department,name,dateofenrollement,telephonenumber) values
(2001,'Neethu','2015-10-10','8956232536'),
(2001,'Sarika','2015-10-10','8478532536'),
(2003,'Diya','2024-04-08','9847523656'),
(2002,'Manu','2025-01-01','9526362514')

insert into student_Registration(student,subject) values
(10000,1),
(10001,2),
(10002,4),
(10003,3)

select s.studentid,s.name,p.course from student_registration sr
inner join student s on s.studentid=sr.student
inner join subject p on p.subjectid=sr.subject

update dean set name='Renuka Mukharjee' where name='Renuka Sharma'

update student set telephonenumber='8105874639' where name='Diya'


select name as studentName from student
select name as College_Name from college
select name as course_name from course
select name as Professor_Name from professor

select p.name as professor_name,d.name as department_Name from professor p
inner join department d on d.DID=p.department and d.name='Science'

select p.name as professor,cr.name as course from professor p
inner join course cr on p.department=cr.department and p.name='Jithin'

select p.name as professor, cr.name as course from professor p
inner join subject s on s.professor=p.PID
inner join course cr on s.course=cr.courseid where p.name='Jithin'

select s.name as Student_Name,d.name as Department from student s  
inner join department d on s.department=d.DID
order by d.DID

select name as College_name from college order by name desc

select sb.name as subject,cr.name as course from subject sb
inner join course cr 
on sb.course=cr.courseid and cr.name='BCA'

select count(distinct s.course) as Numberof_courses_with_Coputer_subject from subject s
where s.name like'%Computer%'

select p.name as professor,sb.name as subject from professor p
inner join subject sb
on p.PID=sb.professor order by sb.name





