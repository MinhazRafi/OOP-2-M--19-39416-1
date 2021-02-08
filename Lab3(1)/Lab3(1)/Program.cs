using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_1_
{
   public class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("rafi","19","cse",3.7f);
            s1.Name = "rafi";
            s1.Id = "19";
            s1.Department = "cse";
            s1.Cgpa = 3.7f;
            s1.ShowInfo();
            Course c1 = new Course("c#","1011",12);
            //c1.CourseName = "c#";
            //c1.CourseCode = "1011";
            c1.ShowCourseInfo();
        }
    }
}
