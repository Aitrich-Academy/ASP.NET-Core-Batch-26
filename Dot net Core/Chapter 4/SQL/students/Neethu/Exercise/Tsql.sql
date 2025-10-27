create procedure AddStudent
@Department int,
@sname varchar(20),
@dateofenrollement smalldatetime,
@phno varchar(20)
as
begin
insert into student (department,name,dateofenrollement,telephonenumber) values(@Department,@sname,@dateofenrollement,@phno)
end

addstudent @department=2003,@sname='zia',@dateofenrollement='2021-01-01',@phno=8543265457
addstudent @department=2003,@sname='Mary',@dateofenrollement='2021-01-01',@phno=8543245757

select * from student

create procedure Updatestudent
@studid int,
@phno varchar(20)
as
begin
update student set telephonenumber=@phno where studentid=@studid
end

updatestudent @studid=10004,@phno=5555555555

create procedure Deletestudent
@studid int
as
begin
delete from student where studentid=@studid
end

deletestudent @studid=10005

create procedure RetriveCom_Depat
@departid int
as
begin
select * from student where department=@departid
end

RetriveCom_Depat @departid=2003

create function Listdean(@deanid int)
returns table
as
return
(
select c.University,c.name as college,d.name as Dean from College c
inner join Dean d
on c.Dean=d.DeanID where c.Dean=@deanid
);

select * from dbo.Listdean(206);

create function ListCollege1(@Universityname varchar(20))
returns table
as 
return
(select u.UID,u.name as University,c.name as College from University u
inner join College c
on u.UID=c.University
where u.Name=@Universityname);

SELECT * FROM dbo.ListCollege1('MG University')

EXEC sp_help 'University';


