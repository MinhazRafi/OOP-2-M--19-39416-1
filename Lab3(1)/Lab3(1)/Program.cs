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
            Student s1 = new Student("Minhaz", "19", "CSE", 3.7f);
            //s1.Name = "Minhaz";
            //s1.Id = "19";
            //s1.Department = "CSE";
            //s1.Cgpa = 3.7f;
            s1.ShowInfo();
            Course c1 = new Course("c#","1011",12);
            //c1.CourseName = "c#";
            //c1.CourseCode = "1011";
            //c1.ShowCourseInfo();
            c1.ShowCourseInfo();
            Triangle t1 = new Triangle(67, 87, 90);
            t1.ShowInfo();
            t1.TestTriangle();
            t1.X = 67;
            t1.Y = 87;
            t1.Z = 90;
            Account a1 = new Account("Minhaz", "12345678", 1000);
            a1.ShowInfo();
            a1.Deposit(50);
            a1.Withdraw(45);



        }
    }
}
