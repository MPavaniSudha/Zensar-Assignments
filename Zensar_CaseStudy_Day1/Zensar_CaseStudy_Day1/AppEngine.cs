using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Zensar_CaseStudy_Day1
{
    class Enroll
    {
        private Student student { get; set; }
        private Course course { get; set; }
        private DateTime enrollmentDate { get; set; }
        public Enroll(Student student, Course course, DateTime enrollmentDate)
        {
            this.student = student;
            this.course = course;
            this.enrollmentDate = enrollmentDate;
        }
    }
    class AppEngine
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlCommand cmd1;
        public static SqlCommand cmd2;
        public static SqlCommand cmd3;
        public static SqlCommand cmd4;
        public static SqlCommand cmd5;
        public static SqlCommand cmd6;
        public static SqlCommand cmd7;
        public static SqlCommand cmd8;
        public static SqlCommand cmd9;
        public static SqlDataReader dr;
        static SqlConnection getConnection()
        {
            con = new SqlConnection("Data Source=DESKTOP-3GMMV62\\MSSQLSERVER07;Initial Catalog=CaseStudy;Integrated Security=True;");
            con.Open();
            return con;
        }

        public void Show_all_registered_Students()
        {
            //whenever we need to retrieve total no.of students in the institute and there details from admin level
            con = getConnection();
            cmd = new SqlCommand("Select *from Student", con);
            int res = cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("Student Details : ");
                Console.WriteLine("--------------------------");
                Console.WriteLine("Student Id : " + " " + dr[0]);
                Console.WriteLine("Student Name :" + " " + dr[1]);
                Console.WriteLine("Student DOB :" + " " + dr[2]);

            }
        }

        public void New_StudentRegistration()
        {
            //Whenever we are trying to register for the Institution as a new user as well as admin can also updates new list of student in there institute
                con = getConnection();
                Console.WriteLine("Enter Student id:");
                int Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Student Name:");
                string Name = Console.ReadLine();
                Console.WriteLine("Enter Student Dob");
                string DateOfBirth = Console.ReadLine();
                cmd1 = new SqlCommand("insert into Student values (@Std_id,@S_Name,@S_Dob)", con);
                cmd1.Parameters.AddWithValue("@Std_id", Id);
                cmd1.Parameters.AddWithValue("@S_Name", Name);
                cmd1.Parameters.AddWithValue("@S_Dob", DateOfBirth);
                int res1 = cmd1.ExecuteNonQuery();
                if (res1 > 0)
                {
                    Console.WriteLine("Student details inserted Sucessfully");
                }
                else
                    Console.WriteLine("please enter valid student details");
        }
        public void Introducing_NewCourse()
        {
            //Admin trying to introduce new courses for there institution
            int n;
            Console.WriteLine("Enter No of Course Details you Want to insert............");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                con = getConnection();
                Console.WriteLine("Enter Course Details CourseId,CourseName,Duration,Fee_Structure");
                int CId, Fees;
                string CName, Duration;
                CId = Convert.ToInt32(Console.ReadLine());
                CName = Console.ReadLine();
                Duration = Console.ReadLine();
                Fees = Convert.ToInt32(Console.ReadLine());
                cmd2 = new SqlCommand("insert into Course values (@cid,@CName,@dur,@fee)", con);
                cmd2.Parameters.AddWithValue("@cid", CId);
                cmd2.Parameters.AddWithValue("@CName", CName);
                cmd2.Parameters.AddWithValue("@dur", Duration);
                cmd2.Parameters.AddWithValue("@fee", Fees);
                int res2 = cmd2.ExecuteNonQuery();
                if (res2 > 0)
                {
                    Console.WriteLine("Course details inserted Sucessfully");
                }
                else
                    Console.WriteLine("Please enter valid Course details");
            }
        }

        public void Available_Courses()
        {
            //Admin module reveals courses in there Institute
            con = getConnection();
            cmd6 = new SqlCommand("Select *from Course", con);
            int res6 = cmd6.ExecuteNonQuery();
            Console.WriteLine("Courses Available In the Institution are................!");
            dr = cmd6.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("Course Details : ");
                Console.WriteLine("--------------------------");
                Console.WriteLine("Course Id : " + " " + dr[0]);
                Console.WriteLine("Course Name :" + " " + dr[1]);
                Console.WriteLine("Course Duration :" + " " + dr[2]);
                Console.WriteLine("Course Fees :" + " " + dr[3]);
                Console.WriteLine();
            }
        }
        public void Enrolling_Courses()
        {
            con = getConnection();
            int SId, CID;
            DateTime EnrollDate;
            Console.WriteLine("Enter Student Id");
            SId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Course Id");
            CID = Convert.ToInt32(Console.ReadLine());
            EnrollDate = DateTime.UtcNow;
            cmd3 = new SqlCommand("insert into enroll values(@Cid,@Stdid,@enroldate)", con);
            cmd3.Parameters.AddWithValue("@Cid", CID);
            cmd3.Parameters.AddWithValue("@stdid", SId);
            cmd3.Parameters.AddWithValue("@enroldate", EnrollDate);
            int res3 = cmd3.ExecuteNonQuery();
            if (res3 > 0)
            {
                Console.WriteLine("Student enrolled to the Course Sucessfully");
            }
            else
                Console.WriteLine("Please enter valid details");
        }

        public void UpdateCourseData()
        {
            con = getConnection();
            int CId, Fees;
            string CName, Duration;
            Console.WriteLine("Enter CID:");
            CId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Course Duration:");
            Duration = Console.ReadLine();
            Console.WriteLine("Enter Course Fees:");
            Fees = Convert.ToInt32(Console.ReadLine());
            cmd4 = new SqlCommand("update Course set cdur=@dur,cfee=@fee where cid=@cid", con);
            cmd4.Parameters.AddWithValue("@dur", Duration);
            cmd4.Parameters.AddWithValue("@fee", Fees);
            cmd4.Parameters.AddWithValue("@cid", CId);
            int res4 = cmd4.ExecuteNonQuery();
            if (res4 > 0)
            {
                Console.WriteLine("Course details Updated Sucessfully");
            }
            else
                Console.WriteLine("Please enter valid Course details");
        }

        public void Student_Screen()
        {
            try
            {
                //whenever we are trying to retrieve particular student details
                con = getConnection();
                int SId;
                Console.WriteLine("Enter Student Id");
                SId = Convert.ToInt32(Console.ReadLine());
                cmd5 = new SqlCommand("select *from Student where Std_id=@SId", con);
                cmd5.Parameters.AddWithValue("@SId", SId);
                dr = cmd5.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("Student Details : ");
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("Student Id : " + " " + dr[0]);
                    Console.WriteLine("Student Name :" + " " + dr[1]);
                    Console.WriteLine("Student DOB :" + " " + dr[2]);
                    Console.WriteLine();

                }

        }
            catch (Exception e)
            {
                Console.WriteLine("Students Doesn't Exist.....Start New Registration", e.Message);
            }

}

        public void UpdateStudentData()
        {
            con = getConnection();
            Console.WriteLine("Enter Student ID:");
            int Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student Name:");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter Student DOB:");
            string DateOfBirth = Console.ReadLine();
            cmd7 = new SqlCommand("update Student set S_Name=@S_Name,S_Dob=@S_Dob where Std_id=@Std_id", con);
            cmd7.Parameters.AddWithValue("@Std_id", Id);
            cmd7.Parameters.AddWithValue("@S_Name", Name);
            cmd7.Parameters.AddWithValue("@S_Dob", DateOfBirth);
            int res5 = cmd7.ExecuteNonQuery();
            if (res5 > 0)
            {
                Console.WriteLine("Student details Updated Sucessfully");
            }
            else
                Console.WriteLine("please enter valid student details");

        }

        public void DeleteStudentData()
        {
            con = getConnection();
            Console.WriteLine("Enter Student ID:");
            int Id = Convert.ToInt32(Console.ReadLine());
            cmd8 = new SqlCommand("delete Student where Std_id=@Std_id", con);
            cmd8.Parameters.AddWithValue("@Std_id", Id);
            int res6 = cmd8.ExecuteNonQuery();
            if (res6 > 0)
            {
                Console.WriteLine("Row Deleted Sucessfully");
            }
            else
                Console.WriteLine("please enter valid student details");


        }

        public void DeleteCourseData()
        {
            try
            {
                con = getConnection();
                int CId;
                Console.WriteLine("Enter Course id:");
                CId = Convert.ToInt32(Console.ReadLine());
                cmd9 = new SqlCommand("delete Course where cid=@cid", con);
                cmd9.Parameters.AddWithValue("@cid", CId);
                int res7 = cmd9.ExecuteNonQuery();
                if (res7 > 0)
                {
                    Console.WriteLine("Row Deleted Sucessfully");
                }
                else
                    Console.WriteLine("please enter valid Course details");
            }
            catch (Exception e)
            {
                Console.WriteLine("You Cannot Delete this Course because Student already enrolled to this Course");
            }
        }
            public void Retrieve_Particular_Course()
              {
                try
                {
                    //whenever we are trying to retrieve particular student details
                    con = getConnection();
                    int CId;
                    Console.WriteLine("Enter Course Id");
                    CId = Convert.ToInt32(Console.ReadLine());
                    cmd = new SqlCommand("select *from Course where cid=@cid", con);
                    cmd.Parameters.AddWithValue("@cid", CId);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Console.WriteLine("Particular Course Details : ");
                        Console.WriteLine("--------------------------");
                        Console.WriteLine("Course Id : " + " " + dr[0]);
                        Console.WriteLine("Course Name :" + " " + dr[1]);
                        Console.WriteLine("Course Duration :" + " " + dr[2]);
                        Console.WriteLine("Course Fees :" + " " + dr[3]);
                        Console.WriteLine();
                    }
                }
                catch (SqlException e)
                {
                    Console.WriteLine("Course Doesn't Exist...........!", e);
                }

            }

    }
}
