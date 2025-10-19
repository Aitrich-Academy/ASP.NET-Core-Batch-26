CREATE DATABASE TABLES
USE master;
ALTER DATABASE TABLES SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
DROP DATABASE TABLES;
CREATE TABLE EMPLOYEE (
EmpNo BIGINT primary key,
EName VARCHAR(50),
DeptNo BIGINT,
Job VARCHAR(10),
HireDate DATETIME)
CREATE TABLE DEPT(
DeptNo BIGINT primary key,
DName VARCHAR(20),
Loc VARCHAR(20))
create table TS_Company_Master(
Id int primary key,
Name varchar(20),
Remarks varchar(100))
create table TS_Group_Master(
Id int primary key,
Name varchar(20),
Remarks varchar(100))
create table TS_Item_Master(
Id int primary key,
Name varchar(20),
Company_id int foreign key references TS_Company_Master(Id),
Group_id int foreign key references TS_Group_Master(Id) ,
Rate decimal ,
Remarks varchar(100))
create table TS_Purchse_Header(
Id int primary key,
Purchase_no bigint,
Trns_Date Datetime,
Total decimal,
Remarks varchar(100))
create table TS_Purchase_Detail(
Id int primary key,
Header_id int foreign key references TS_Purchse_Header(Id),
Sl_no int,
Item_id int,
Qty int,
Rate decimal(10,2),
Amount decimal(10,2))
