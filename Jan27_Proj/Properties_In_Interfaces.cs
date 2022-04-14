using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan27_Proj
{
    interface IName
    {
        string Name { get; set; }
    }
    class Employee : IName
    {
        string empname;
        public string Name
        {
            get { return empname; }
            set { empname = value; }
        }
    }
    class Company : IName
    {
        int age { get; set; }
        string ComName { get; set; }

        public string Name
        {
            get { return ComName; }
            set { ComName = value; }
        }
    }
    class Properties_In_Interfaces
    {
        static void Main()
        {
            IName e = new Employee();
            e.Name = "Pavani";
            IName c = new Employee();
            c.Name = "Zensar";
        }

    }
}
