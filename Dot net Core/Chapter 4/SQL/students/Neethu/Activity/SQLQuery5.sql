select * from TS_Company_Master
select * from TS_Group_Master
insert into TS_Company_Master values 
(5,'rama',''),
(6,'priya',''),
(7,'raju',''),
(8,'priya',''),
(9,'Miya',''),(10,'Jaanvi','')
select * from TS_Company_Master where name like '%a%'
select * from TS_Company_Master where name like 'j%'
select * from TS_Company_Master where name like '%a'
select * from TS_Company_Master where name like '_a%'
select * from TS_Company_Master where name like '__a%'
select id,name from TS_Company_Master union 
select id,name from TS_Group_Master
select id,name from TS_Company_Master union all
select id,name from TS_Group_Master
select name from TS_Company_Master union
select name from TS_Group_Master
select name from TS_Company_Master union all
select name from TS_Group_Master
select * from TS_Company_Master,TS_Group_Master
select ABS(-2.4)
select abs(5)
SELECT FLOOR(32.55) 
SELECT FLOOR(-32.15) 
SELECT FLOOR($32.15) 
SELECT CEILING(32.15) 
SELECT CEILING(-32.15) 
SELECT CEILING($32.15) 
SELECT ROUND(32.15 ,1) 
SELECT ROUND(32.14 ,1) 
SELECT ROUND(32.14998 ,4) 
select round(32.14998,2)
select round(32.13222,2)
select round(32.13228,4)
alter table employee add salary decimal
insert into EMPLOYEE values
(101,'Neethu',001,'Developer','2020-12-12',50000),
(102,'Miya',002,'Tester','2020-12-12',35000),
(103,'Neethu',003,'Accoundant','2020-12-12',25000)
select avg(salary) from EMPLOYEE
select count(*) from TS_Company_Master

select count(distinct name) from TS_Company_Master
select max(salary) from EMPLOYEE
select min(salary) from employee
select sum(salary) from employee
select ascii('s')
select ('My')+space(2)+('Name is')+space(4)+('Neethu')
select replace('I LOVE MY COUNTRY','COUNTRY','INDIA')
select left('I LOVE MY COUNTRY',5)
select RIGHT('I LOVE MY COUNTRY',8)
select replicate('india',10)
select SUBSTRING('I LOVE MY COUNTRY',3,4)
select len('I LOVE MY COUNTRY')
select REVERSE('I LOVE MY COUNTRY')
select lower('I LOVE MY COUNTRY')
select upper('i love my country')
select LTRIM('  i love my country')
select RTRIM('I LOVE MY COUNTRY           ')
select * from TS_Company_Master where name='priya' and id=8
select * from TS_Company_Master where name='priya' and id=1
select * from TS_Company_Master where name='priya' or id=1
select id,name from TS_Company_Master where name in('priya','miya','raju')
select id,name from TS_Company_Master where name not in('priya','miya','raju')
select * from TS_Company_Master where id >=2
select * from TS_Company_Master where id >2
select * from TS_Company_Master where id <=2
select * from TS_Company_Master where id <2
select * from TS_Company_Master where id = 2
select * from TS_Company_Master where id between 2 and 4
select name from TS_Company_Master group by name
select name,count(*) from TS_Company_Master group by name
select name from TS_Company_Master order by name
select name from TS_Company_Master order by name desc
select distinct(name) from TS_Company_Master
SELECT CAST(10.6496 AS int) 

select 'The salary is' +cast(salary as varchar(12))as salary from EMPLOYEE where salary between 20000 and 40000








