using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Student
    {
        int Rollno,SEM,sum=0,avg;
        string name, branch, Class;
        int[] Marks = new int[5];
        public Student(int rn, string nam, string cls, int sm, string br)
        {
            Rollno = rn;
            name = nam;
            Class = cls;
            SEM = sm;
            branch = br;
        }
        public void DisplayResult()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter Subject{0} Marks", i+1);
                Marks[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                sum = sum + Marks[i];
            }
            avg = sum / 5;
            Console.WriteLine("The Average Marks Of Student is:{0}", avg);
            for (int i = 0; i < 5; i++)
            {
                if (Marks[i] < 35)
                {
                    Console.WriteLine("Student Result is Failed");
                }
                else if ((Marks[i] > 35) && (avg < 50))
                {
                    Console.WriteLine("Student Result is Failed");
                }
                else
                {
                    Console.WriteLine("Student Result is Passed");
                }
            }
        }
        
        public void DisplayData()
        {
            Console.WriteLine("Enter  the Student Details");
            Console.WriteLine("RollNO:{0}\nName:{1}\nClass:{2}\nSEM:{3}\nBranch:{4}", Rollno, name, Class, SEM, branch);
            Console.WriteLine("Enter the Marks of the Student");
            DisplayResult();
        }
        static void Main()
        {
            Student sd = new Student(576,"Pavani","Second Year",4,"CSE");
            sd.DisplayData();


        }
    }
    
}
