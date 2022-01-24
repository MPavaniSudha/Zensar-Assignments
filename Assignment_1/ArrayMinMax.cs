using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class ArrayMinMax
    {
        static void Main()
        {
            int sum = 0, n, min, max;
            float avg;
            Console.WriteLine("Enter No Of Elements into an Array:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Elements into an array:");
            int[] arr = new int[5];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                sum += arr[i];
            }
            avg = sum / n;
            Console.WriteLine("Average value of array elements:{0}", avg);
            Array.Sort(arr);
            Console.WriteLine("min: {0}\nMax: {1}", arr[0], arr[4]);
        }
    }
}
