using System;
using System.Collections.Generic;
using System.Text;

namespace _07122020.Models
{
    public abstract class BaseEntity
    {
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
    }

    public class Student : BaseEntity
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        private int _salary { get; set; }
        // public int Salary { get { return _salary; }  }
        public int Salary => _salary;

        public string FullName()
        { 
            return Name + " " + SurName; 
        }

        public Student(string name)
        {
            this.Name = name;
        }

        public Student(string name, string surname)
        {
            this.Name = name;
            this.SurName = surname;
        }




    }

    public class Teacher : BaseEntity
    { 
        public string teacherSeat { get; set; }
    }
}
