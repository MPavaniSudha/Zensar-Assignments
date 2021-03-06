using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zensar_CaseStudy_Day1
{
    abstract class UserInterface
    {
        public abstract void showFirstScreen();
        public abstract void showStudentScreen();
        public abstract void showAdminScreen();
        public abstract void showAllStudentsScreen();
        public abstract void showStudentRegistrationScreen();
        public abstract void introduceNewCourseScreen();
        public abstract void showAllCoursesScreen();
    }

    class StudAdmin_Details : UserInterface
    {
        string res;
        public override void showFirstScreen()
        {
            do
            {
            Console.WriteLine("Welcome to SMS(Student Management System)");
            Console.WriteLine("Tell us who you are : \n1.Student\n2.Admin");
            Console.WriteLine("Enter your choice ( 1 or 2 ) : ");
            int op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    showStudentScreen();
                    break;
                case 2:
                    showAdminScreen();
                    break;
                default:
                    Console.WriteLine("Enter valid Option....!");
                    break;

            }
               Console.WriteLine("Do you want to continue Main Screen:Y or N");
               res = Console.ReadLine();
            } while ((res == "Y") || (res == "y"));
        }

        public override void showStudentScreen()
        {
            do 
            { 
            AppEngine ae = new AppEngine();
            Console.WriteLine("Select: \n1.Check your Details(Existing User)\n2.Registration(New User)\n3.Search Available Courses\n4.Enroll to Course in List");
            int op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        // Checks whether new registrartion or already existing user
                        ae.Student_Screen();
                        Console.WriteLine("Action Completed you may Exit....!");
                        break;
                    case 2://New registration
                        this.showStudentRegistrationScreen();
                        Console.WriteLine("Action Completed you may Exit....!");
                        break;
                    case 3:
                        //Showcase all available courses
                        Console.WriteLine("--------------------List of Courses------------------------");
                        ae.Available_Courses();
                        Console.WriteLine("Action Completed you may Exit....!");
                        break;
                    case 4:
                        //Student enrolling to particular course
                        ae.Enrolling_Courses();
                        Console.WriteLine("You have successfully enrolled you may Exit the Screen now");
                        break;
                    default:
                        Console.WriteLine("Enter valid Option....!");
                        break;
                }
                Console.WriteLine("Do you want to continue Student Screen:Y or N");
                res = Console.ReadLine();
            } while ((res == "Y") || (res == "y"));
        }

        public override void showAdminScreen()
        {
            do
            { 
            AppEngine aE = new AppEngine();
            Console.WriteLine("Select: \n1.Introduce New Course\n2.Courses Available\n3.Update Course Details\n4.Retrieve Particular Course in List\n5.Deleting Existing Student\n6.Delete Course\n7.Update Student Details\n8.All Registered Students");
            int op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    //If any new course want to add for Organization
                    this.introduceNewCourseScreen();
                    Console.WriteLine("Action Completed you may Exit....!");
                    break;
                case 2:
                    //list of existing courses
                    Console.WriteLine("-------------All Available Courses in Institute-------------------");
                    this.showAllCoursesScreen();
                    Console.WriteLine("Action Completed you may Exit....!");
                    break;
                case 3:
                    //updates in Course structure
                    aE.UpdateCourseData();
                    Console.WriteLine("Action Completed you may Exit....!");
                    break;
                case 4:
                    //getting particular course details
                    aE.Retrieve_Particular_Course();
                    Console.WriteLine("Action Completed you may Exit....!");
                    break;
                case 5:
                    //deletes particular student
                    aE.DeleteStudentData();
                    Console.WriteLine("Action Completed you may Exit....!");
                    break;
                case 6:
                    //deletes existing course only that are not enrolled by any students
                    aE.DeleteCourseData();
                    Console.WriteLine("Action Completed you may Exit....!");
                    break;
                case 7:
                    //modify existing student details
                    aE.UpdateStudentData();
                    Console.WriteLine("Action Completed you may Exit....!");
                    break;
                case 8:
                    //Gives ALL Students Details
                    showAllStudentsScreen();
                    break;

                default:
                    Console.WriteLine("Enter valid Option....!");
                    break;
            }
                Console.WriteLine("Do you want to continue Admin Screen:Y or N");
                res = Console.ReadLine();
            } while ((res == "Y") || (res == "y"));

        }
        public override void showAllStudentsScreen()
        {
            AppEngine Ae = new AppEngine();
            Ae.Show_all_registered_Students();
        }

        public override void showStudentRegistrationScreen()
        {
            AppEngine Ae = new AppEngine();
            Ae.New_StudentRegistration();

        }
        public override void introduceNewCourseScreen()
        {
            AppEngine Ae = new AppEngine();
            Ae.Introducing_NewCourse();
        }
        public override void showAllCoursesScreen()
        {
            AppEngine Ae = new AppEngine();
            Ae.Available_Courses();
        }

    }
}
