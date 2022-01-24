using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class CelsiusFahrenheit
    {
        static void Main()
        {
            float Fahreinheit,Celsius;
            Console.WriteLine("Enter Fahrenheit Value");
            Fahreinheit = Convert.ToSingle(Console.ReadLine());
            Celsius = ((Fahreinheit - 32) * 5 / 9);
            Console.WriteLine("Celsius:{0}", Celsius);
            Console.ReadLine();

        }
    }
}
