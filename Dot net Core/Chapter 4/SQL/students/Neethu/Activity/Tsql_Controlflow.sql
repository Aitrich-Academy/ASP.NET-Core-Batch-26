declare @Student_Mark int;
set @Student_Mark=55;
if @Student_Mark>50
	print 'Pass'
else 
	print 'Fail'

select
	case
	when @Student_Mark>80 then 'Grade A'
	when @Student_Mark between 65 and 80 then 'Grade B'
	when @Student_Mark between 50 and 65 then 'Grade C'
	else 'Fail'
	end as 'Student Grade'

declare @num int;
set @num=10;
while @num<=15
begin
	print 'Number is : ' + cast(@num as varchar(5))
	set @num=@num+1;
end
