create database HireMeNowDB

create table users(
Id uniqueidentifier default newid() primary key,
firstname varchar(50) null,
lastname varchar(50) null,
email varchar(100) not null unique,
gender varchar(30) null,
location varchar(50) null,
phone varchar(50) null,
password varchar(50) null,
role varchar(50) null,
about varchar(50) null,
designation varchar(50) null,
companyid uniqueidentifier null,
image varchar(100) null,
status varchar(50) null)

DROP table users

drop table jobs

create table jobs(
Id uniqueidentifier default newid() primary key,
title varchar(50) null,
description varchar(100) null,
location varchar(50) null,
experience varchar(30) null,
typeofworkplace varchar(50) null,
responsibilities varchar(100) null,
salary varchar(50) null,
jobtype varchar(50) null,
vacanciescount int null,
appliedcount int null,
companyid uniqueidentifier null,
status varchar(50) null)

select * from users
select * from jobs
select * from applications

alter table jobs add createdby uniqueidentifier foreign key references users(id)

create table applications(
Id uniqueidentifier default newid() primary key,
userid uniqueidentifier not null foreign key references users(id),
jobid uniqueidentifier not null foreign key references jobs(id),
applieddate date null,
status varchar(50) null)

drop table applications

insert into users
(firstname,lastname,email,gender,location,phone,password,role,about,designation,companyid,image,status) values
('Soudha', 'AM', 'soudha.aitrich@gmail.com','Female', 'Thrissur', NULL, '123', 'Jobprovider', NULL, NULL, NULL, 'Active', NULL),
('yadhu', 'krishna', 'yadhu.aitrich@gmail.com', NULL, 'Thrissur', NULL, '123', 'Jobseeker', NULL, NULL, NULL, 'Active', NULL)

update users set phone='8085499250',location='kochi',about='Experienced .NET developer with 5+ years of experience in building Enterprise applications'
where email='yadhu.aitrich@gmail.com'
 
alter table users alter column about varchar(100)

select * from users where role='jobseeker'

select * from users where role='jobprovider'

delete from users where email='shini@gmail.com'

insert into jobs (title,description,location,experience,typeofworkplace,salary,responsibilities,jobtype,vacanciescount,appliedcount,companyid,status,createdby)
values
('Dotnet Developer', 'need a senior dotnet lead developer', 'thrissur', '2', 'WFH', '500000-800000', 'need to lead a team ', 'FullTime', 50, 14,  'ab5f391e-d83e-4eae-87cd-bca23175cf22','Active', 'DFABFBC0-4140-4E21-B423-D6D82C9F397E')

Select j.Title,j.Description,j.Responsibilities,j.Experience,j.Location  from jobs j,users u where u.Email='yadhu.aitrich@gmail.com' and j.CreatedBy=u.Id

select * from jobs where title like '%dotnet%' 

select * from jobs where location='thrissur'

select j.title,j.description,j.experience,j.responsibilities,j.location, u.firstname from jobs j inner join users u on u.id=j.createdby

insert into applications (userid,jobid,applieddate,status) 
values
('DFABFBC0-4140-4E21-B423-D6D82C9F397E','12FBF207-B56F-4767-9F31-4260A85D0EC1','2023-10-11','Pending')

select * from applications,users u where u.id=applications.userid and u.email='yadhu.aitrich@gmail.com'

select j.title,u.firstname,u.location from applications a 
inner join jobs j on j.Id=a.jobid
inner join users u on u.id=a.userid

update applications set status='Cancelled' where jobid='12FBF207-B56F-4767-9F31-4260A85D0EC1'

delete from applications where jobid='12FBF207-B56F-4767-9F31-4260A85D0EC1'
