
//4.Write a program in C# Sharp to declare a structure called Books with a property, a method to display the value of Book_id, and a private field called Book_id (int)


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    struct Book
    {
        public string Name;
        private int Book_id { get; set; }
           
            public int Book_ID
            {
                      get { return Book_id; }
                      set { Book_id = value; }
            }
          public void Display()
          {
            Console.WriteLine("Book ID is: {0}", Book_id);
            Console.WriteLine("Book Name is: {0}", Name);
          }

    }
    class Structures
    {
        static void Main()
        {
            Book b1 = new Book();
             b1.Book_ID = 576;
             b1.Name= "Wings of Fire";
             b1.Display();
             Console.Read();


        }
    }
}

/*OUTPUT:
-----------------------------------------
Book ID is: 576
Book Name is: Wings of Fire*/

