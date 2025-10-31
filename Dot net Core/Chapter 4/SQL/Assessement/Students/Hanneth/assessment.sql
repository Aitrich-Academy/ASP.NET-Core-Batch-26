create database assessment 
use assessment


create table employee(
emp_id int identity(1,1) primary key,
name varchar(30) not null,
dept_id int foreign key references departments(dept_id),
salary int not null,
hire_date date not null)

drop table employee
select * from employee
select * from departments

insert into employee(name,dept_id,salary,hire_date) values
('Alice',10,50000,'2021-01-15'),
('Bob',20,60000,'2020-04-20'),
('Charlie',10,45000,'2019-07-10'),
('David',30,70000,'2022-03-01'),
('Eva',null,55000,'2023-06-12')

insert into employee(name,dept_id,salary,hire_date) values
('subadra',20,70000,'2026-10-15'),
('Rishikesh',20,50000,'2025-10-10')


insert into employee(name,dept_id,salary,hire_date) values
('subaida',30,70000,'2026-10-15'),
('Rishi',30,50000,'2025-10-10')

create table departments(
dept_id int identity(10,10) primary key,
dept_name varchar(30) not null)

insert into departments(dept_name) values
('HR'),('IT'),('Sales'),('Finance')


1
select e.name,d.dept_name from employee as e
join departments as d
on e.dept_id=d.dept_id

2.
select name from employee where salary>(select AVG(salary) from employee)

3.
select d.dept_name from departments as d 
join employee e on d.dept_id=e.dept_id
group by d.dept_name
having count(e.emp_id)>1 

4.
select dept_name from employee as e
join departments as d
on e.dept_id=d.dept_id

5.

select * into newemployee from employee
select * from newemployee

select * into newdepartment from departments
select * from newdepartment
6.
select d.dept_name ,count= count(*) 
from departments as d 
join employee as e
on d.dept_id=e.dept_id
group by d.dept_name
order by count desc


7.
select top 2 name,dept_id from employee where dept_id=20

8.
select * from employee where salary>(select AVG(salary) from employee where dept_id=30)

9.
update employee set salary= salary+(salary*0.1) where dept_id=10


10.
with rank 
as(select e.name,
e.salary,
d.dept_name,
ROW_NUMBER() over (partition by e.dept_id order by e.salary desc) as rn
from
employee e
join
departments d
on e.dept_id=d.dept_id)
select dept_name,
name,salary
from
rank
where rn=1

