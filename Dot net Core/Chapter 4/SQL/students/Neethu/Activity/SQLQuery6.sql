create table students1(
studentId int primary key,
sname varchar(15) not null)
create table marks(
studentId int,
subject varchar(10),
mark int)
drop table students1
drop table marks
insert into students1 values(
1,'Apsara'),
(2,'Rahul'),
(3,'Neha'),
(4,'John')
insert into marks values
(1,'Math',80),
(2,'Science',70),
(4,'Math',60),
(5,'English',90)
select * from students1
select * from marks

select students1.sname,marks.subject,marks.mark
from students1
inner join marks
on students1.studentId=marks.studentId

select students1.sname,marks.subject,marks.mark
from students1
left join marks
on students1.studentId=marks.studentid

select students1.studentId,marks.subject,marks.mark
from students1
right join marks
on students1.studentId=marks.studentId

select students1.sname,marks.subject,marks.mark
from students1
full outer join marks
on students1.studentId=marks.studentId