-------------------------------Assignment 3-----------------------------------------------------
/*
1. Write a T-SQL Program to generate complete payslip of a given employee with respect to the following condition
a) HRA as 10% Of sal
b) DA as 20% of sal
c) PF as 8% of sal
d) IT as 5% of sal
e) Deductions as sum of PF and IT
f) Gross Salary as sum of SAL,HRA,DA and Deductions
g) Net salary as Gross salary- Deduction
*/
begin
declare @salary float=45000
declare @SAL float
declare @HRA float,@DA float,@PF float,@IT float
declare @deductions float,@GrossSal float,@NetSal float
set @HRA=@salary*0.1
print 'HRA is:'
print @HRA
set @DA=@salary*0.2
print 'DA is:'
print @DA
set @PF=@salary*0.08
print 'PF is:'
print @PF
set @IT=@salary*0.05
print 'IT is:'
print @IT
set @deductions=@PF+@IT
print 'Deductions is:'
print @deductions
set @SAL=@salary-(@HRA+@DA+@deductions)
set @GrossSal=@SAL+(@HRA+@DA+@deductions)
print 'Gross salary is'
print @GrossSal
set @NetSal=@GrossSal-@deductions
print 'Net Salary is'
print @NetSal
end


----2.Write a T-SQL Program to Display complete result of a given student.
--(Note: Consider 10th standard result sheet and Student table structure as (sno,sname,maths,phy,comp)

begin
declare @SNo int,@SName varchar(20),@Maths int,@Physics int,@Computer int,@Total int,@Percentage int
declare @Result varchar(20)
set @SNo=1
set @SName='Pavani'
set @Maths=95
set @Physics=86
set @Computer=95
set @Total=(@Maths+@Physics+@Computer)
set @Percentage=(@Total*100)/300
print @Percentage
 create table Result(
Sno int,Sname varchar(20),Maths int,Physics int,Computer int,Total int,Percentage int)
insert into Result
values(@SNo,@SName,@Maths,@Physics,@Computer,@Total,@Percentage)
select *from Result
end

----3.Write a T-SQL Program to find the factorial of a given number.

begin
declare @n int
declare @fact int
set @n=6
set @fact=1
while @n>0
begin
set @fact=@fact*@n
set @n=@n-1
end
print 'Factorial of given number is'
print @fact
end

----4.Create a stored procedure to generate multiplication tables up to a given number.

create or alter procedure pro_multi
as
begin
declare @i int=1,@num int=8,@n int
while @i<=10
begin
set @n=@num*@i
print @n
set @i=@i+1
end
end
-----execute the above procedure---
exec pro_multi

/*5.Create a user defined function calculate Bonus for all employees of a  given job using following conditions
a.For Deptno10 employees 15% of sal as bonus.
b.For Deptno20 employees  20% of sal as bonus
c.For Others employees 5%of sal as bonus*/

select * from EMP
--function Creation--
create or alter function Calculate_Bonus(@ejob varchar(15))
returns table
as
return (select Ename,Job,Sal,Deptno from EMP Where job=@ejob)
go
update EMP set Sal=Sal+(Sal*0.15) where Deptno=10
update EMP set Sal=Sal+(Sal*0.2) where Deptno=20
update EMP set Sal=Sal+(Sal*.05) where Deptno<>10 and Deptno<>20 

------- to execute the above function--
select * from Calculate_Bonus('ANALYST')

/*6.Create a trigger to restrict data manipulation on EMP table during General holidays. 
Display the error message like “Due to Independence day you cannot manipulate data”
Note: Create holiday table as (holiday_date,Holiday_name) store at least 4 holiday details*/

---create holiday table----
create table Holiday
(holiday_date varchar(20),
Holiday_name varchar(20))

--inserting values into Holiday table---
insert into Holiday values('15-AUG','Independence Day'),
('26-JAN','Republic Day'),
('1-JAN','New Year'),
('2-OCT','Gandhi Jayanthi'),
('5-SEP','Teachers Day')

select * from Holiday

----trigger creation----
create or alter trigger RestrictDataManipulation
on Holiday
instead of update
as
   Raiserror('Due to Public Holiday You Cannot Manipulate the Data',16,1)

update Holiday set holiday_date='4-JAN' where holiday_date='1-JAN'

