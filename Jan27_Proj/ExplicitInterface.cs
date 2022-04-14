using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan27_Proj
{
    class ExplicitInterface
    {
        interface Iinterface1
        {
            string Message(string s);
        }

        interface Iinterface2
        {
            string Message(string s);
        }
        class ExplicitInterfaces : Iinterface1, Iinterface2
        {
            string Iinterface1.Message(string s)//explicit implementation
            {
                return "Hello" + " " + s;
            }

            public string Message(string s)//default implementation
            {
                return "Hi" + " " + s;
            }
            static void Main()
            {
                //first way to invoke the methods of the class
                Iinterface1 ie1 = new ExplicitInterfaces();
                Iinterface2 ie2 = new ExplicitInterfaces();
                Console.WriteLine(ie1.Message("Pavani"));
                Console.WriteLine(ie2.Message("Sri"));

                //second way of invoking the methods
                ExplicitInterfaces ei = new ExplicitInterfaces();
                Console.WriteLine(ei.Message("Zensar"));
                Console.WriteLine(((Iinterface1)ei).Message("Sudha"));
                Console.WriteLine(((Iinterface2)ei).Message("Swetha"));
                Console.Read();
            }


        }
    }
 }
