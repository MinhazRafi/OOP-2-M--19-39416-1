using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceBasic
{
    class Student
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private string dob;

        public string Dob
        {
            get { return dob; }
            set { dob = value; }
        }
        private string bloodGrp;

        public string BloodGrp
        {
            get { return bloodGrp; }
            set { bloodGrp = value; }
        }
        private float cgpa;

        public float Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }
        public Student()
        { 
        }
        public Student(string name,string id)
        {
            this.name = Name;
            this.id = Id;
        }
        
        
        
        
        
    }
}
