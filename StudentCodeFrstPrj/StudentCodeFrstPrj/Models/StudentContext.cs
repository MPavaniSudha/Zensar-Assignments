using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentCodeFrstPrj.Models
{
    public class StudentContext:DbContext
    {
        public StudentContext() : base("name=Students")
        {

        }
        public DbSet<StudentDetails> students { get; set; }
    }
}