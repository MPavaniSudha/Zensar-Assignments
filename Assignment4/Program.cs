
//Create a Console application with a Class called Program which has TotalFare as Constant, Name, Age.  Accept Name, 
//Age from the user and call the CalculateConcession() function

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculateConcession; 


namespace Assignment4
{
    class Program
    {
        static void Main()
        {
            String Name;
            Console.WriteLine("Enter Name of the Citizen");
            Name = Console.ReadLine();
            Concession cc = new Concession();
            cc.CalculateConcession1();
        }
    }
}

/*OUTPUT:
----------------------------------------------------------------------
TestCase 1:
Enter Name of the Citizen
BhanuRekha Mam
Enter age of the Citizen
30
Ticket Booked With the payment of 500
Press any key to continue . . .

TestCase 2:
Enter Name of the Citizen
Pavani
Enter age of the Citizen
4
Littel Champs - Free Ticket
Press any key to continue . . .

 TestCase 2:*/