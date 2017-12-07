using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR10_person_student_teacher
{
    public class Student : Person
    {
        public void GoToClasses()
        {
            Console.WriteLine("I'm going to class.");
        }

        public void ShowAge()
        {
            Console.WriteLine($"My age is {_age} years old.");
        }
    }
}
