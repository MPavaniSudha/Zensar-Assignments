using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class StringReverse
    {
        static void Main()
        {
            string name, rev="";
            Console.Write("Enter String:");
            name = Console.ReadLine();
            int len = name.Length-1;
            while (len >= 0)
            {
                rev = rev + name[len];
                len--;
            }
            Console.WriteLine("Reverse of a Given String is:{0}", rev);
            Console.ReadLine();
            
        }
    }

}
