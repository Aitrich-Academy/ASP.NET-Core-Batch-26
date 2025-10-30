Declare @SName varchar(15);
Declare @SAge int;
Declare @Exam_Date date;

set @SName='Miya';
select @SAge=11;
set @Exam_Date='2025-10-10';

Print 'Student Name: '+@SName;
print 'Age is: ' +cast(@SAge as varchar(10));
print 'Exam Date is: '+format(@exam_date,'2025-10-10');