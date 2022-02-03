
//2..Create a Class called Products with Productid, Product Name, Price. Accept 10 Products, sort them based on the price,
//and display the sorted Products


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Products
    { 
        static void Main()
        {
           
            SortedList<double, string> Prod = new SortedList<double, string>();
            Console.WriteLine("Enter 10 Product Details:");
            for(int i=0;i<10;i++)
            {
                Console.WriteLine("Enter Product{0} Details:", i + 1);
                Console.WriteLine("Enter ProductPrice and ProductName");
                Prod.Add(Convert.ToDouble(Console.ReadLine()), Console.ReadLine());
            }

            Console.WriteLine("After Sorting the Price of Products is:");
            foreach(KeyValuePair<double,string> Pr in Prod)
            {
                Console.WriteLine("ProductName:{1}\nProductPrice:{0}", Pr.Key,Pr.Value);
            }

        }
    }
}


/*OUTPUT:
-------------------------------------------------------------------------
Enter 10 Product Details:
Enter Product1 Details:
Enter ProductPrice and ProductName
35000
AC
Enter Product2 Details:
Enter ProductPrice and ProductName
1500
Mouse
Enter Product3 Details:
Enter ProductPrice and ProductName
18000
TV
Enter Product4 Details:
Enter ProductPrice and ProductName
2000
Keyboard
Enter Product5 Details:
Enter ProductPrice and ProductName
20000
Refrigerator
Enter Product6 Details:
Enter ProductPrice and ProductName
45000
IPhone
Enter Product7 Details:
Enter ProductPrice and ProductName
15000
Cooler
Enter Product8 Details:
Enter ProductPrice and ProductName
3500
MixerGrinder
Enter Product9 Details:
Enter ProductPrice and ProductName
25000
WashingMachine
Enter Product10 Details:
Enter ProductPrice and ProductName
4500
Grinder

After Sorting the Price of Products is:
ProductName:Mouse  
ProductPrice:1500
ProductName:Keyboard 
ProductPrice:2000
ProductName:MixerGrinder
ProductPrice:3500
ProductName:Grinder 
ProductPrice:4500
ProductName:Cooler
ProductPrice:15000
ProductName:TV
ProductPrice:18000
ProductName:Refrigerator
ProductPrice:20000
ProductName:WashingMachine
ProductPrice:25000
ProductName:AC
ProductPrice:35000
ProductName:IPhone
ProductPrice:45000
Press any key to continue . . .*/
