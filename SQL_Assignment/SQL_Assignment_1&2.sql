create database AssignmentEx1
--create emp table
create table EMP
(Empno int primary key,
Ename varchar(20),
Job varchar(30),
Mgr int,
Hiredata date,
Sal float, 
Comm int,
Deptno int foreign key references DEPT(DeptNo))

select * from EMP

--insert data into emp table
insert into EMP
values
(7369, 'SMITH', 'CLERK',    7902, '17-DEC-80', 800,null, 20), 
(7499, 'ALLEN', 'SALESMAN', 7698, '20-FEB-81', 1600,300, 30),
(7521, 'WARD',  'SALESMAN', 7698, '22-FEB-81', 1250,500, 30),
(7566, 'JONES',  'MANAGER', 7839, '02-APR-81', 2975,null, 20),
(7654, 'MARTIN',  'SALESMAN',7698, '28-SEP-81', 1250,1400, 30),
(7698, 'BLAKE',  'MANAGER',  7839, '01-MAY-81', 2850,null, 30),
(7782, 'CLARK',  'MANAGER',  7839, '09-JUN-81', 2450,null, 10),
(7788, 'SCOTT',  'ANALYST',  7566, '19-APR-87', 3000,null, 20),
(7839, 'KING',  'PRESIDENT',  null, '17-NOV-81', 5000,null, 10),
(7844, 'TURNER',  'SALESMAN', 7698, '08-SEP-81', 1500,0, 30),
(7876, 'ADAMS',  'CLERK',     7788, '23-MAY-87',1100,null, 20),
(7900, 'JAMES',  'CLERK',     7698, '03-DEC-81', 950,null, 30),
(7902, 'FORD',   'ANALYST',   7566, '03-DEC-81', 3000,null, 20),
(7934, 'MILLER', 'CLERK', 7782, '23-JAN-82', 1300,null, 10)


--Create table Department
create table DEPT
(DeptNo int primary key,
Dname varchar(30),
Loc varchar(30))
---insert data into department table
insert into DEPT
values
(10, 'Accounting', 'New York'),
(20, 'Research', 'Dallas'),
(30, 'Sales', 'Chicago'),
(40, 'Operations', 'Boston')

select *from DEPT

--1. List all employees whose name begins with 'A'. 
select * from EMP where Ename like 'A%'

--2. Select all those employees who don't have a manager. 
select * from EMP where Mgr is null

--3. List employee name, number and salary for those employees who earn in the range 1200 to 1400.
select Ename, Empno,Sal from EMP where Sal between 1200 and 1400

--4. Give all the employees in the RESEARCH department a 10% pay rise. Verify that this has been done by listing all their details before and after the rise. 
select Deptno,Ename,Sal,(Sal+(Sal*10/100))'New Salary' from EMP where Deptno = 20

--5. Find the number of CLERKS employed. Give it a descriptive heading. 
select count(Job) 'Total_number_of_Clerks' from EMP Where Job='Clerk'

--6. Find the average salary for each job type and the number of people employed in each job.
select Job,count(*)'No_of_Persons',avg(Sal)'Avg_Salary' from EMP 
group by(Job)

--7. List the employees with the lowest and highest salary. 
select Ename,Sal from EMP
where Sal=(select(min(Sal))from EMP)
select Ename,Sal from EMP
where Sal=(select(max(Sal))from EMP)

--8. List full details of departments that dont have any employees.
select * from DEPT where Deptno not in(select Deptno from EMP)

--9. Get the names and salaries of all the analysts earning more than 1200 who are based in department 20. Sort the answer by ascending order of name. 
select Ename, Sal from EMP where Job = 'ANALYST' and Sal > 1200 and Deptno= 20
order by Ename

--10. For each department, list its name and number together with the total salary paid to employees in that department. 
select Dname, count(*)DeptNo,sum(sal)'Total_Salary' from Dept,EMP where EMP.Deptno=DEPT.DeptNo
group by(Dname)

--11. Find out salary of both MILLER and SMITH.
select Sal from EMP where Ename='MILLER' or Ename='SMITH'

12. Find out the names of the employees whose name begin with ‘A’ or ‘M’.
select Ename from EMP where Ename like 'A%' or  Ename like 'M%'

--13. Compute yearly salary of SMITH. 
select Sal,(Sal*12) 'Annal_Salary' from EMP where Ename='SMITH'

--14. List the name and salary for all employees whose salary is not in the range of 1500 and 2850. 
select Ename,Sal from Emp where Sal not between 1500 and 2850

--------------------------Assignment-2-------------------------
--1. Retrieve a list of MANAGERS. 
select * from EMP where Job='MANAGER'

--2. Find out salary of both MILLER and SMITH.
select Ename,Sal from EMP where Ename like 'MILLER' or Ename like 'SMITH'

--3 Find out the names and salaries of all employees earning more than 1000 per month
select Ename,Sal from EMP where Sal>1000

--4. Display the names and salaries of all employees except JAMES. 
select Ename,Sal from EMP where Ename !='JAMES'

--5. Find out the details of employees whose names begin with ‘S’. 
select *from EMP where Ename like 'S%'

--6.Find out the names of all employees that have ‘A’ anywhere in their name.
select Ename from EMP where Ename like '%A%'

--7.Find out the names of all employees that have ‘L’ as their third character in their name. 
select Ename from EMP where Ename like '__L%'

--8.Find out the names of the employees whose name begin with ‘A’ or ‘M’. 
select Ename from EMP where Ename like 'A%' or  Ename like 'M%'

--9.Compute yearly salary of SMITH. 
select Sal,(Sal*12) 'Annal_Salary' from EMP where Ename='SMITH'

--10.Compute daily salary of JONES.
select Sal,(Sal/30) 'Daily_Salary' from EMP where Ename='JONES'

--11.Calculate the total monthly salary of all employees.
select sum(Sal)'total_Monthly_Salaries' from EMP

--12.Print the average annual salary.
select avg(Sal*12)'Avg_Annual_Salary' from EMP

--13.Select the name, job, salary, department number of all employees except SALESMAN from department number 30.
select Ename,Job,Sal,Deptno from EMP where Job !='SALESMAN' and Deptno=30

--14.List unique departments of the EMP table.
select distinct(Deptno) from EMP

--15.List the name and salary of employees who earn more than 1500 and are in department 10 or 30. Label the columns Employee and Monthly Salary respectively.
select Ename as 'EMPLOYEES',Sal as 'Monthly_Salary' from EMP where Sal>1500 and (Deptno=10 or Deptno=30)

