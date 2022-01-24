using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class EvenOdd
    {
       static void Main()
        {
            int num;
            Console.WriteLine("Enter a Number:");
            num = Convert.ToInt32(Console.ReadLine());
            if(num%2 == 0)
            {
                Console.WriteLine("The Given Number {0} is an Even Number",num);
            }
            else
            {
                Console.WriteLine("The Given Number {0} is an Odd Number",num);
            }
        }

    }
}
