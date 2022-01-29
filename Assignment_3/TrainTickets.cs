
//1.Create a console application to book train tickets. Create a Passanger class with (Name, Age) and write a function called
//TicketBooking(no_of_tickets) that takes no.of tickets to be booked. If the no of tickets is > 5 per booking, raise an user defined exception,
//and print "cannot book more than 2 tickets". Else Print  "Ticket Booked Successfully". Add a Test class to call TicketBooking method by accepting all required details.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment_3
{
    class TicketBookingException:ApplicationException
    {
        public TicketBookingException(string msg) : base(msg)
        {

        }
    }
    class Passanger 
    {
       public  string name;
       public int age;
        public int n;

       public void TicketBooking(int no_of_tickets)
        {
            if (no_of_tickets > 5)
            {
                throw (new TicketBookingException("Cannot book more than 5 tickets"));
            }
            else
                Console.WriteLine("Ticket Booked Successully");
        }
    }
    class Test:Passanger
    {
        
        public void test()
        {
            Console.WriteLine("Enter Passanger Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter Age of the Passanger");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter No of Tickets Booked");
             n = Convert.ToInt32(Console.ReadLine());
                TicketBooking(n);
            
        }
    }
    class TrainTickets
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            try
            {
                t.test();
            }
           catch(TicketBookingException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.Read();
        }
    }
}

/*OUTPUT:
------------------------------------------
Test Case:1

Enter Passanger Name
Pavani
Enter Age of the Passanger
22
Enter No of Tickets Booked
4
Ticket Booked Successully

Test Case:2

Enter Passanger Name
Sudha
Enter Age of the Passanger
22
Enter No of Tickets Booked
6
Cannot book more than 5 tickets*/
