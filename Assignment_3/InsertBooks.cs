
//6. Write a program in C# Sharp to insert the information of two books. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Assignment_3
{
    class InsertBooks
    {
        struct IBooks
        {
            public string name;
            public string Author;
        }
        static void Main()
        {

            IBooks[] ib = new IBooks[2];
            Console.WriteLine("Insert the Information of two Books");
            Console.WriteLine();
            for (int i = 0; i < 2; i++)
            {
                Console.Write("Information of Book{0}:", i + 1);
                Console.Write("\nEnter Name of the Book:");
                ib[i].name = Console.ReadLine();
                Console.Write("Enter the Author of the Book:");
                ib[i].Author = Console.ReadLine();
                Console.WriteLine();
            }

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("{0}: Title = {1}, Author = {2}", i + 1, ib[i].name, ib[i].Author);
                Console.WriteLine();
            }
        }
    }
}


/*OUTPUT:-------------------------------------------------------------
Insert the Information of two Books

Information of Book1:
Enter Name of the Book:BASIC
Enter the Author of the Book:S.TROELSTRA

Information of Book2:
Enter Name of the Book:C +
Enter the Author of the Book:G.RTRTG

1: Title = BASIC, Author = S.TROELSTRA

2: Title = C +, Author = G.RTRTG

Press any key to continue . . .*/