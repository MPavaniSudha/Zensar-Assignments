using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class StudentMarks
    {
        static void Main()
        {
            
            int total=0, avg, min, max;
            Console.WriteLine("Enter your Marks");
            int[] arr = new int[10];
            for(int i=0;i<10;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i<10;i++)
            {
                total += arr[i];
            }
            Console.WriteLine("Total:{0}", total);
            avg = total / 10;
            Console.WriteLine("Average:{0}", avg);

            Array.Sort(arr);
            Console.WriteLine("min: {0}\nMax: {1}", arr[0], arr[9]);
             Console.WriteLine("Display Marks In Ascending Order");
            Array.Sort(arr);
            for(int i=0;i<10;i++)
            {
                Console.WriteLine(arr[i]);
            }
           
            Console.WriteLine("Display Marks In Descending Order");
            Array.Reverse(arr);
            for(int i=0;i<10;i++)
             {
                Console.WriteLine(arr[i]);
             }
        }
    }
}
