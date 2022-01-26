using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class LengthofString
    {
        static void Main(string[] args)
        {
            string username;
            Console.Write("Enter UserName:");
            username = Console.ReadLine();
            int len=username.Length;
            Console.WriteLine("The Length of the Given Username is:{0}", len);
            Console.Read();

        }
    }
}
