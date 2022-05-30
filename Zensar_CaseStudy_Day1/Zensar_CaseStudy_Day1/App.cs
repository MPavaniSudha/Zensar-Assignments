using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zensar_CaseStudy_Day1
{ 
    class App
    {
        public static void Scenario1()
        {
            Console.WriteLine("------------Student:Scenario1-----------------");
            Info info = new Info();
            Student student = new Student(101,"Shekhar","02-04-1996\n");
            Student student1 = new Student(102,"Sravya","04-02-1997\n");
            Student student2 = new Student(103,"Santhi","05-05-1998\n");
            info.display(student);
            info.display(student1);
            info.display(student2);
        }

        public static void Scenario2()
        {
            Console.WriteLine("------------Student:Scenario2-----------------");
            Info info = new Info();
            Student[] std = new Student[3];
            std[0] = new Student(501, "Rakesh", "03-06-1998");
            std[1] = new Student(502, "Ramya", "04-08-1999");
            std[2] = new Student(503, "Raksha", "23-06-1997");
            for (int i = 0; i < std.Length; i++)
            {
                info.display(std[i]);
                Console.WriteLine();
            }
        }
        public static void Scenario3()
        {
            Console.WriteLine("------------Student:Scenario3-----------------");
            Student[] std = new Student[3];
            for (int i = 0; i < std.Length; i++)
            {
                Console.WriteLine("Enter the Student ID:");
                int Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Student Name:");
                string Name = Console.ReadLine();
                Console.WriteLine("Enter the Student DateOfBirth:");
                string DateOfBirth = Console.ReadLine();
                Student s1 = new Student(Id, Name, DateOfBirth);
                std[i] = s1;
            } 
            foreach (var r in std)
            {
               Console.WriteLine("\nStudent ID:{0}\nStudent Name:{1}\nStudent DOB:{2}\n",r.Id,r.Name,r.DateOfBirth);
            }
        }

        public static void CScenario1()
        {
            Console.WriteLine("--------------Course:Scenario1---------------");
            Info info = new Info();
            Course crse = new Course(1, "JAVASCRIPT","1 Month",5000);
            Course crse1 = new Course(2, "HTML", "1 Month",7000);
            Course crse2 = new Course(3, "Devops", "2 Months",10000);
            info.display(crse);
            Console.WriteLine();
            info.display(crse1);
            Console.WriteLine();
            info.display(crse2);

        }

        public static void CScenario2()
        {
            Console.WriteLine("------------Course:Scenario2-----------------");
            Info info = new Info();
            Course[] cse = new Course[3];
            cse[0] = new Course(4, "CLanguage", "2 Months",8000);
            cse[1] = new Course(5, "DBMS", "1 Months",6000);
            cse[2] = new Course(6, "RLanguage", "2 Months",12000);
            for (int i = 0; i < cse.Length; i++)
            {
                info.display(cse[i]);
                Console.WriteLine();
            }
        }

        public static void CScenario3()
        {
            Console.WriteLine("------------Course:Scenario3-----------------");
            Course[] cse = new Course[3];
            for (int i = 0; i < cse.Length; i++)
            {
                Console.WriteLine("Enter Course ID:");
                int Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Course Name:");
                string Name = Console.ReadLine();
                Console.WriteLine("Enter Course Duration:");
                string Duration = Console.ReadLine();
                Console.WriteLine("Enter Course Fee:");
                int fee = int.Parse(Console.ReadLine());
                Course c1 = new Course(Id, Name, Duration,fee);
                cse[i] = c1;
            }
            foreach (var r in cse)
            {
                Console.WriteLine("\nCourse ID:{0}\nCourse Name:{1}\nCourse Duration:{2}\nCourse Fee:{3}\n", r.CID, r.CName, r.Duration,r.Fees);
            }
        }
        static void Main(string[] args)
        {
            AppEngine apen = new AppEngine();
            //Scenario1();
            //Scenario2();
            //Scenario3();
            //CScenario1();
            //CScenario2();
            //CScenario3();
            StudAdmin_Details sd = new StudAdmin_Details();
            sd.showFirstScreen();
            Console.Read();
        }
    }
}
