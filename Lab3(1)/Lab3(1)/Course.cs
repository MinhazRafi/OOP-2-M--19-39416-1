using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_1_
{
    public class Course
    {
        String courseName;
        String courseCode;
        int courseCredit;

        public Course(String courseName, String courseCode,int courseCredit)
        {
            this.courseName = courseName;
            this.courseCode = courseCode;
            this.courseCredit = courseCredit;
        }

        public String CourseName
        {
            set { this.courseName = value; }
            get { return courseName; }
        }
        public String CourseCode
        {
            set { this.courseCode = value; }
            get { return courseCode; }
        }
        public int CourseCredit
        {
            set { this.courseCredit = value; }
            get { return courseCredit; }
        }
    

public void ShowCourseInfo()
{
    Console.WriteLine("Course name is :" + courseName);
    Console.WriteLine("Course code is :" + courseCode);
    Console.WriteLine("Course credit is :" + courseCredit);
}

    }
}
