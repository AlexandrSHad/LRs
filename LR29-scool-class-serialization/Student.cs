using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR29_scool_class_serialization
{
    [Serializable]
    public class Student
    {
        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Student()
        {
            FirstName = "";
            LastName = "";
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1}", LastName, FirstName);
        }
    }
}
