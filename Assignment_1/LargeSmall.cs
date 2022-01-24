using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class LargeSmall
    {
        static void Main()
        {
            int a, b, c;
            Console.WriteLine("Please enter a,b,c values");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            //check the Largest one
            if ((a>b) && (a>c))
            {
                Console.WriteLine("{0} is the Largest One", a);
            }
            else if (b>c)
            {
                Console.WriteLine("{0} is the Largest One", b);
            }
            else
            {
                Console.WriteLine("{0} is the Largest One", c);
            }

            //Check the smallest one
            if ((a<b)&& (a<c))
            {
                 Console.WriteLine("{0} is the Smallest One", a);
            }
            else if (b<c)
            {
                Console.WriteLine("{0} is the Smallest One", b);
            }
            else
            {
                Console.WriteLine("{0} is the Smallest One", c);
            }


        }


    }
}
