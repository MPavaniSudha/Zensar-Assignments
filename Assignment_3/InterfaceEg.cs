
//3.Create an Interface IStudent with StudentId and Name as Properties, ShowDetails() as its method. Create 2 classes Dayscholar and Resident that implements the interface Properties and Methods.Test The functionalities.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    interface IStudent
    {
         void ShowDetails(string name,int id);

    }
    class Dayscholar : IStudent
    {
        public void ShowDetails(string name, int id)
        {
            Console.WriteLine("Name of the Student:{0}\nID of the Student:{1}",name,id);
        }
    }
    class Resident:IStudent
    {
        public void ShowDetails(string name,int id)
        {
           Console.WriteLine("Name of the Student:{0}\nID of the Student:{1}",name,id);
        }
    }
        class InterfaceEg
        {
             static void Main()
             {
                Console.WriteLine("**********DayScholar_Student_Details*********");
                IStudent id= new Dayscholar();
                id.ShowDetails("Pavani",576);
                Console.WriteLine("**********Residential_Student_Details*********");
                IStudent sd = new Resident();
                 sd.ShowDetails("Sudha",586);


        }
        }
    }

/*OUTPUT:
 -------------------------------------------------------
********** DayScholar_Student_Details*********
 Name of the Student:Pavani
 ID of the Student:576
 * *********Residential_Student_Details * ********
 Name of the Student:Sudha
 ID of the Student:586
Press any key to continue . . .*/
