
//3. Create a simple Stationery application to add items and display added items using Generic collections


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Stationary
    {
        static void Main()
        {
            List<string> ls = new List<string>();
            ls.Add("Pencil");
            ls.Add("Pen");
            ls.Add("Eraser");
            ls.Add("Scale");
            ls.Add("Books");
            ls.Add("Shapaner");

            foreach(var item in ls)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}

/*OUTPUT
---------------------------------------------------------------------------------
Pencil
Pen
Eraser
Scale
Books
Shapaner*/


