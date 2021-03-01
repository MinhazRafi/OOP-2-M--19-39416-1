using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Rafi","19394161",3.75f);
            Student s2 = new Student("Rakib","1939416",3.5f);
            Student s3 = new Student("Rakin","3293435",4.00f);
            Student s4 = new Student("Rakhi","2312435",3.8f);

            Department d1 = new Department("Computer Science", "CS");
            Department d2 = new Department("Electrical Eng", "EEE");
            s1.Dept = d1;
            s2.Dept = d1;
            s3.Dept = d2;
            d1.AddStudent(s1, s2, s3);
            d2.AddStudent(s4);

            s1.ShowDepartmentInfo();
            s3.ShowDepartmentInfo();
            Console.WriteLine("");
            d1.Name = "Computer Science & Eng";
            d1.Id = "CSE";
            s1.ShowDepartmentInfo();
            d1.PrintStudents();
            s4.Name = "Rakhi";
            d2.PrintStudents();
        }
        }
    }

