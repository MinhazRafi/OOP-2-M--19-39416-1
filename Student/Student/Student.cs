using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Student
    {
        string name;
        string id;
        double cgpa;

        public void showInfo()
        {
            Console.WriteLine("name is :"+name);
            Console.WriteLine("id is :"+id);
            Console.WriteLine("cgpa is :"+cgpa);
        }
    }
}
