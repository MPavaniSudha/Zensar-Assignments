using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class StringCompare
    {
        static void Main()
        {
            string s1, s2;
            Console.WriteLine("Enter first String");
            s1 = Console.ReadLine();
            Console.WriteLine("Enter Second String");
            s2 = Console.ReadLine();
            if(s1==s2)
            {
                Console.WriteLine("String1 is same as String2");
            }
            else
            {
                Console.WriteLine("String1 is  not same as String2");
            }
        }
    }
}
