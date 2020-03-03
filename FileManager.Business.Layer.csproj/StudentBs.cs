using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.Common.Layer
{
    public class Student
    {
        public Student(int studentId, string name, string lastname, string dateofbirth)
        { StudentId = studentId;
            Name = name;
            LastName = lastname;
            DateOfBirth = dateofbirth;
        }

        public Student()
        {

        }
        public int StudentId {  get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }

        public string ReturnStudent()
        {
            return $"{StudentId}, {Name}, {LastName}, {BirthDate}";
        }
    }
}
