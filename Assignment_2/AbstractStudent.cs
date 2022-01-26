using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    abstract class AbstractStudent
    {
        public string Name;
        public int StudentId;
        public float Grade;
        abstract public Boolean Ispassed(float grade);
    }

    class UnderGraduate : AbstractStudent
    {
        public override Boolean Ispassed(float grade)
        {
            Console.WriteLine("Enter the Name of the Student");
            Name = Console.ReadLine();
            Console.WriteLine("Student Name:{0}", Name);
            Console.WriteLine("Enter The ID of the Student");
            StudentId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("StudentID:{0}", StudentId);

            if (grade >= 70.0f)
            {
                Console.WriteLine("Result is:");
                return true;
            }
            else
            {
                Console.WriteLine("Result is:");
                return false;
            }
        }
    }
    class Graduate : AbstractStudent
    {
        public override Boolean Ispassed(float grade)
        {
            Console.WriteLine("Enter the Name of the Student");
            Name = Console.ReadLine();
            Console.WriteLine("Student Name:{0}", Name);
            Console.WriteLine("Enter The ID of the Student");
            StudentId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("StudentID:{0}", StudentId);

            if (grade >= 70.0f)
            {
                Console.WriteLine("Result is:");
                return true;
            }
            else
            {
                Console.WriteLine("Result is:");
                return false;
            }
        }
    }

    class AbstractClass
    {
        static void Main()
        {
            UnderGraduate UG = new UnderGraduate();
            Console.WriteLine(UG.Ispassed(68.4f));
            Graduate G = new Graduate();
            Console.WriteLine(G.Ispassed(83.4f));
        }
    }
}
