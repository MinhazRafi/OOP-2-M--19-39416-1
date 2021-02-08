using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_1_
{
   public class Student
    {
       String name;
       String id;
       String department;
       float cgpa;

       public Student(String name,String id,String department,float cgpa)
       {
           this.name = name;
           this.id = id;
           this.department = department;
           this.cgpa = cgpa;
       }

       public String Name
       {
           set {name=value;}
           get {return name;}
       }
       public String Id
       {
           set { id = value; }
           get { return id; }
       }
       public String Department
       {
           set { department = value; }
           get { return department; }
       }
       public float Cgpa
       {
           set { cgpa = value; }
           get { return cgpa; }
       }

       public void ShowInfo()
       {
           Console.WriteLine("Nmae is :"+name);
           Console.WriteLine("Id :"+id);
           Console.WriteLine("Department name :"+department);
           Console.WriteLine("Cgpa :"+cgpa);

       }
    }
}
