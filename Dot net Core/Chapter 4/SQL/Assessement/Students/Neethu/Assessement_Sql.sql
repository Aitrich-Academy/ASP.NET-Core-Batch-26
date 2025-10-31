create database assessement

create table employees(
emp_Id int identity(1,1) primary key,
name varchar(20) not null,
dept_id int foreign key references departments(dept_id),
salary int not null,
hire_date date)

create table departments(
dept_id int identity(10,10) primary key,
dept_name varchar(20) not null)

insert into departments (dept_name) values
('HR'),
('IT'),
('Sales'),
('Finance')

insert into employees (name,dept_id,salary,hire_date) values 
('Miya',20,20000,'2020-03-20'),
('Jithin',20,35000,'2010-01-01'),
('Alice',10,50000,'2021-01-15'),
('Bob',20,60000,'2020-04-20'),
('Charlie',10,45000,'2019-07-10'),
('David',30,70000,'2022-03-01'),
('Eva',null,55000,'2023-06-12')

select * from departments
select * from employees

select e.name,d.dept_name from employees e
left join departments d
on e.dept_id=d.dept_id
group by e.name,d.dept_name

select name,salary from employees
where salary>(select avg(salary) from employees)

select d.dept_name as department,count(e.emp_id) as No_Of_Employees from departments d
inner join employees e
on d.dept_id=e.dept_id
group by d.dept_name,d.dept_id
having count(e.emp_id)>1

select * from departments

select * into departments1 from departments

select * from departments1

select d.dept_name as department,count(e.emp_id) as No_Of_Employees from departments d
inner join employees e
on d.dept_id=e.dept_id
group by d.dept_name,d.dept_id
order by No_Of_Employees desc

select top 2 name as Employee_Name,salary from employees
group by dept_id,name,salary
having dept_id=20
order by salary desc

select name as Employee,Salary from employees
where salary>(select avg(salary) from employees where dept_id=30)

update employees set salary=salary+(salary*0.1) 
where dept_id=(select dept_id from departments where dept_name='HR')

select e.name,e.salary,d.dept_name from employees e
inner join departments d
on e.dept_id=d.dept_id
where e.salary=(select max(e1.salary) from employees e1 where e1.dept_id=e.dept_id)




 








