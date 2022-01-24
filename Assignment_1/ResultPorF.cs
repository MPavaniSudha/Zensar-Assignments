using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class ResultPorF
    {
        static void Main()
        {
            string name;
            int n = 3;
            float sum, avg,CSharp,HTML,SQL;
           
            for (int i=1;i<=5;i++)
             {
                Console.WriteLine("Enter Student Name:");
                name = Console.ReadLine();
                Console.WriteLine("Enter CSHarp Marks:");
                CSharp = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Enter HTML Marks:"); 
                HTML = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Enter SQL Marks:");
                SQL = Convert.ToSingle(Console.ReadLine());
                sum = CSharp + HTML + SQL;
                avg = sum / n;
                if(avg>50)
                {
                    Console.WriteLine("Passed");
                }
                else
                {
                    Console.WriteLine("Failed");
                }

            }
        }
    }
}
