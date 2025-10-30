insert into TS_Company_Master values
(1,'P&G',''),
(2,'XENICAL',''),
(3,'J&J',''),
(4,'JAC','')
select * from TS_Company_Master
insert into TS_Group_Master values
(1,'INHALAER',''),
(2,'DROPS',''),
(3,'POWDER',''),
(4,'OINMENT','')
select * from TS_Group_Master
delete from TS_Company_Master where id=1
delete from TS_Group_Master where name='inhalaer'
update TS_Company_Master set name='P&G' where id=2
insert into EMPLOYEE values
(2000,'jaanvi',123,'developer','12/12/20'),
(2002,'Miya',254,'Tesster','23/02/18')
update EMPLOYEE set HireDate='2020-12-12' where EmpNo=2000
select * from employee
update EMPLOYEE set HireDate='2023-02-12' where EmpNo=2002
update employee set EName=(select EName from EMPLOYEE where EmpNo=2000)
select id,name  into Copy_Company from TS_Company_Master 
select * from Copy_Company
select * into copy_ts_company_master from TS_Company_Master
select * from copy_TS_Company_Master
alter table  copy_ts_company_master alter column id varchar(10)
alter table copy_ts_company_master add age int
sp_rename copy_ts_company_master,duplicate_ts_company_master
select * from duplicate_ts_company_master
sp_renamedb tables,tablecollections

