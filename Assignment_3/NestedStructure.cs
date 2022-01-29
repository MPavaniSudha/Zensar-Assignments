
//5.Write a program in C# Sharp to create a nested structure to store two data for an employee in an array.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    struct emp
    {
        public string Name;
        public  emp1 e;
    }
    struct emp1
    {
        public int date;
        public int month;
        public int year;
    }
    class NestedStructure
    {
        static void Main()
        {
            emp[] e2 = new emp[2];
            for(int i=0;i<2;i++)
            {
                Console.Write("Enter the Name of the Employee:");
                e2[i].Name = Console.ReadLine();

                Console.Write("Enter day of the birth:");
                e2[i].e.date =Convert.ToInt32( Console.ReadLine());

                Console.Write("Enter Month of the birth:");
                e2[i].e.month = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Year for the birth:");
                e2[i].e.year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Name of the Employee:{0}\nDay of the birth:{1}\nMonth of the birth:{2}\nYear for the birth:{3}", e2[i].Name, e2[i].e.date, e2[i].e.month, e2[i].e.year);
                Console.WriteLine();
            }
        }
    }
}

/*OUTPUT:
------------------------------------------------------
Name of the Employee:Pavani
Day of the birth:7
Month of the birth:5
Year for the birth:1998

Name of the Employee:Sudha
Day of the birth:4
Month of the birth:3
Year for the birth:1997

Press any key to continue . . .*/
