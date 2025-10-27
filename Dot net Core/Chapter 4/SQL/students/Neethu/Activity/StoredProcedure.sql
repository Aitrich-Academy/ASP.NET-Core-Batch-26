create table  student2(
studentId int identity(1,1),
Sname varchar(15),
Smark int)

drop table student2

create procedure AddStudent
@Sname varchar(10),
@smark int
as
begin
insert into student2 (Sname,Smark) values (@Sname,@smark)
end

AddStudent @Sname='Neethu', @smark=55
AddStudent @Sname='Miya', @smark=70

select * from student2

create procedure UpdateMark
@studentid int,
@smark int

as
begin
update student2 set Smark=@smark where studentId=@studentid
end

UpdateMark @smark=80,@studentid=1



