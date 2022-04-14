using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan27_Proj
{
    class Employees
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public double Salary { get; set; }
        public Employees(int ID, string Name, double Salary)
        {
            this.ID = ID;
            this.Name = Name;
            this.Salary = Salary;
        }
        public object this[int index]
        {
            //get accessors to return values
            get
            {
                if (index == 0)
                    return ID;
                else if (index == 1)
                    return Name;
                else if (index == 2)
                    return Salary;
                else
                    return null;
            }
            set
            {
                if (index == 0)
                    ID = Convert.ToInt32(value);
                else if (index == 1)
                    Name = value.ToString();
                else if (index == 2)
                    Salary = Convert.ToDouble(value);
            }
        }

        public object this[string s]
        {
            get
            {
                if (s == "ID")
                    return ID;
                else if (s == "Name")
                    return Name;
                else if (s == "Salary")
                    return Salary;
                else
                    return null;
            }
            set
            {
                if (s == "ID")
                    ID = Convert.ToInt32(value);
                else if (s == "Name")
                    Name = value.ToString();
                else if (s == "Salary")
                    Salary = Convert.ToDouble(value);
            }
        }
        class IndexersEg1
        {
            static void Main()
            {
                Employees emp = new Employees(576, "Pavani", 20000);
                Console.WriteLine("EmployeeID=" + "" + emp[0]);
                Console.WriteLine("Name=" + "" + emp[1]);
                Console.WriteLine("Salary=" + "" + emp[2]);
                emp[0] = 586;
                emp[1] = "Sudha";
                emp[2] = 15000;
                Console.WriteLine("*********After Modifications*************");
                Console.WriteLine("EmployeeID=" + "" + emp[0]);
                Console.WriteLine("Name=" + "" + emp[1]);
                Console.WriteLine("Salary=" + "" + emp[2]);
                Console.WriteLine("***********Using Overloaded Indexers***********");
                Employees emp1 = new Employees(567, "Srivalli", 25000);
                Console.WriteLine("EmployeeID=" + "" + emp1[0]);
                Console.WriteLine("Name=" + "" + emp1[1]);
                Console.WriteLine("Salary=" + "" + emp1[2]);
                emp1[0] = 568;
                emp1[1] = "Vishnu";
                emp1[2] = 16000;
                Console.WriteLine("*********After Modifications*************");
                Console.WriteLine("EmployeeID=" + "" + emp1[0]);
                Console.WriteLine("Name=" + "" + emp1[1]);
                Console.WriteLine("Salary=" + "" + emp1[2]);
            }

        }
    }
}
