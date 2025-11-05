select * from Students
select * from studentlogs
create table StudentLogs(
logid int identity(1,1) primary key,
studname varchar(20),
logdate datetime)

DROP TRIGGER IF EXISTS trg_afterinsertstudents;


create trigger trg_afterinsertstudent
on students
after insert
as
begin
insert into StudentLogs(studname,logdate)
select sname,GETDATE() from inserted
end

insert into students(Sname,age,cid)values('Deepak',28,103),('catalin',24,101),
('Malavika',25,102),
('Ria',22,101)

create trigger trg_afterupdatestudent
on students
after update
as
begin
insert into StudentLogs(studname,logdate)
select sname+('Updated'),GETDATE() from inserted
end

update students set age=20 where Sname='Malavika'
update students set age=21 where Sname='Ria'

create trigger trg_afterdeletestudent
on students
after delete
as
begin
insert into StudentLogs(studname,logdate)
select sname+('Deleted'),GETDATE() from deleted
end

delete students where Sname='Ria'
delete students where Sname='miya'

create trigger trg_insteadofdeletestudent
on students
instead of delete
as
begin
insert into StudentLogs(studname,logdate)
select sname+('Delete attempted'),GETDATE() from deleted
end

