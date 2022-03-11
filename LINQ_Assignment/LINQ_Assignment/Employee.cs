using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Assignment
{
    class Employee
    {
        public int EmployeeID;
        public string FirstName;
        public string LastName;
        public string Title;
        public Date DOB;
        public Date DOJ;
        public string City;
   
        static void Main(string[] args)
        {

            //creating list for employee
            List<Employee> Emplist = new List<Employee>()
            {
                new Employee() { EmployeeID = 1001, FirstName="Malcolm ",LastName ="Daruwalla",Title ="Manager    ",DOB=Date.Parse("16/11/1984"), DOJ=Date.Parse("08/06/2011"), City="Mumbai "},
                new Employee() { EmployeeID = 1002, FirstName="Asdin   ",LastName="Dhalla    ",Title="AsstManager ",DOB=Date.Parse("20/08/1984"), DOJ=Date.Parse("07/07/2012"), City="Mumbai "},
                new Employee() { EmployeeID = 1003, FirstName="Madhavi ",LastName="Oza       ",Title="Consultant  ",DOB=Date.Parse("14/11/1987"), DOJ=Date.Parse("12/04/2015"), City="Pune   "},
                new Employee() { EmployeeID = 1004, FirstName="Saba    ",LastName="Shaikh    ",Title="SE          ",DOB=Date.Parse("03/06/1990"), DOJ=Date.Parse("02/02/2016"), City="Pune   "},
                new Employee() { EmployeeID = 1005, FirstName="Nazia   ",LastName="Shaikh    ",Title="SE          ",DOB=Date.Parse("08/03/1991"), DOJ=Date.Parse("02/02/2016"), City="Mumbai "},
                new Employee() { EmployeeID = 1006, FirstName="Amit    ",LastName="Pathak    ",Title="Consultant  ",DOB=Date.Parse("07/11/1989"), DOJ=Date.Parse("08/08/2014"), City="Chennai"},
                new Employee() { EmployeeID = 1007, FirstName="Vijay   ",LastName="Natrajan  ",Title="Consultant  ",DOB=Date.Parse("02/12/1989"), DOJ=Date.Parse("01/06/2015"), City="Mumbai "},
                new Employee() { EmployeeID = 1008, FirstName="Rahul   ",LastName="Dubey     ",Title="Associate   ",DOB=Date.Parse("11/11/1993"), DOJ=Date.Parse("06/11/2014"), City="Chennai"},
                new Employee() { EmployeeID = 1009, FirstName="Suresh  ",LastName="Mistry    ",Title="Associate   ",DOB=Date.Parse("12/08/1992"), DOJ=Date.Parse("03/12/2014"), City="Chennai"},
                new Employee() { EmployeeID = 1010, FirstName="Sumit   ",LastName="Shah      ",Title="Manager     ",DOB=Date.Parse("12/04/1991"), DOJ=Date.Parse("02/01/2016"), City="Pune   "},
            };

            //1.Display detail of all the employee

            var r = from e in Emplist
                    select e;
            Console.WriteLine("1.Display details of the Employee:\n");
            foreach (var item in r)
            {
                Console.WriteLine(item.EmployeeID + "\t" + item.FirstName + "\t" + item.LastName + "\t" + item.Title + "\t" + item.DOB + "\t" + item.DOJ + "\t" + item.City);
            }
            Console.WriteLine();

            //2.Display details of all the employee whose location is not Mumbai

            Console.WriteLine("2.Display details of all the employee whose location is not Mumbai:\n");
            var r1 = from e in Emplist
                     where e.City !="Mumbai"
                     select e;
            foreach (var item in r1)
            {
                Console.WriteLine(item.EmployeeID+ "\t"+item.FirstName+"\t"+item.LastName+"\t"+item.Title+"\t"+item.DOB +"\t"+item.DOJ+"\t"+item.City);
            }
            Console.WriteLine();

            //3.Display details of all the employee whose title is AsstManager

            Console.WriteLine("3.Display details of all the employee whose title is AsstManager:\n");
            var r2 = from e in Emplist
                     where e.Title.Contains("AsstManager")
                     select e;
            foreach (var item in r2)
            {
                Console.WriteLine(item.EmployeeID + "\t" + item.FirstName + "\t" + item.LastName + "\t" + item.Title + "\t" + item.DOB + "\t" + item.DOJ + "\t" + item.City);
            }
            Console.WriteLine();

            //4.Display details of all the employee whose Last Name start with S

            Console.WriteLine("4.Display details of all the employee whose Last Name start with S\n");
            var r3 = from e in Emplist
                     where e.LastName.StartsWith("S")
                     select e;
            foreach (var item in r3)
            {
                Console.WriteLine(item.EmployeeID + "\t " + item.FirstName + "\t " + item.LastName + "\t" + item.Title + "\t" + item.DOB + " \t" + item.DOJ + "\t " + item.City);
            }
            Console.WriteLine();

            //5.Display a list of all the employee who have joined before 1 / 1 / 2015

            Console.WriteLine("5.Display a list of all the employee who have joined before 1 / 1 / 2015\n");
            var r4 = from e in Emplist
                     where e.DOJ < Date.Parse("1 / 1 / 2015")
                     select e;
            foreach (var item in r4)
            {
                Console.WriteLine(item.EmployeeID + "\t " + item.FirstName + "\t " + item.LastName + "\t" + item.Title + "\t" + item.DOB + " \t" + item.DOJ + "\t " + item.City);
            }
            Console.WriteLine();

            //6.Display a list of all the employee whose date of birth is after 1/1/1990

            Console.WriteLine("6.Display a list of all the employee whose date of birth is after 1/1/1990");
            var r5 = from e in Emplist
                     where e.DOB > Date.Parse("1 / 1 / 1990")
                     select e;
            foreach (var item in r5)
            {
                Console.WriteLine(item.EmployeeID + "\t " + item.FirstName + "\t " + item.LastName + "\t" + item.Title + "\t" + item.DOB + " \t" + item.DOJ + "\t " + item.City);
            }
            Console.WriteLine();

            //7.Display a list of all the employee whose designation is Consultant and Associate

            Console.WriteLine("7.Display a list of all the employee whose designation is Consultant and Associate\n");
            var r6 = from e in Emplist
                     where (e.Title.Contains("Consultant") || e.Title.Contains("Associate"))
                     select e;
            foreach (var item in r6)
            {
                Console.WriteLine(item.EmployeeID + "\t " + item.FirstName + "\t " + item.LastName + "\t" + item.Title + "\t" + item.DOB + " \t" + item.DOJ + "\t " + item.City);
            }
            Console.WriteLine();

            //8.Display total number of employees

            Console.WriteLine("8.Display total number of employees\n");
            var r7 = (from e in Emplist
                      select e.EmployeeID).Count();
            Console.WriteLine("Total number of employees: {0}", r7);
            Console.WriteLine();

            //9.Display total number of employees belonging to “Chennai

            Console.WriteLine("9.Display total number of employees belonging to “Chennai”\n");
            var r8 = (from e in Emplist
                      where e.City == "Chennai"
                      select e.EmployeeID).Count();
            Console.WriteLine("Total number of employees from chennai: {0}", r8);
            Console.WriteLine();

            //10.Display highest employee id from the list

            Console.WriteLine("10.Display highest employee id from the list\n");
            int r9 = (from e in Emplist
                      select e.EmployeeID).Max();
            Console.WriteLine("Highest employee ID from the list is: {0}", r9);
            Console.WriteLine();

            //11.Display a list of all the employee who have joined after 1 / 1 / 2015

            Console.WriteLine("11.Display a list of all the employee who have joined after 1 / 1 / 2015\n");
            var r10 = from e in Emplist
                      where e.DOJ > Date.Parse("1 / 1 / 2015")
                      select e;
            foreach (var item in r10)
            {
                Console.WriteLine(item.EmployeeID + "\t " + item.FirstName + "\t " + item.LastName + "\t" + item.Title + "\t" + item.DOB + " \t" + item.DOJ + "\t " + item.City);
            }
            Console.WriteLine();

            //12.Display total number of employee whose designation is not “Associate

            Console.WriteLine("12.Display total number of employee whose designation is not “Associate”\n");
            int r11 = (from e in Emplist
                       where e.Title != "Associate"
                       select e.EmployeeID).Count();
            Console.WriteLine("Number of employees other than Associates: {0}", r11);
            Console.WriteLine();

            //"13.Display total number of employee based on City

            Console.WriteLine("13.Display total number of employee based on City\n");
            var r12 = from e in Emplist
                      group e by e.City into e1
                      select new { cnt = e1.Count(), e1.First().City, };
            foreach (var item in r12)
            {
                Console.WriteLine("Number of employees:{0} in City:{1}", item.cnt, item.City);
            }
            Console.WriteLine();

            //14.Display total number of employee based on city and title

            Console.WriteLine("14.Display total number of employee based on city and title\n");
            var r13 = (from e in Emplist
                       group e by (e.City, e.Title) into city
                       orderby city.Key
                       select city);
            foreach (var item in r13)
            {
                Console.WriteLine(item.Key + "\t" + item.Count());
            }
            Console.WriteLine();

            //15.Display total number of employee who is youngest in the list

            Console.WriteLine("15.Display total number of employee who is youngest in the list\n");
            var r14 = (from e in Emplist
                      group e by (e.DOB, e.EmployeeID) into DOB
                      orderby DOB.Key descending
                      select DOB);
            Console.WriteLine("The Youngest Employee in the List is:");
            foreach (var item in r14)
            {
                Console.WriteLine($"Employee ID:{item.Key} and Count of Employees:{item.Count()}");
                Console.ReadLine();
            }
            Console.ReadLine();


        }
    }
}


             