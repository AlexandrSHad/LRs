using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR10_person_student_teacher
{
    public class Person
    {
        protected int _age;

        public void Hello()
        {
            Console.WriteLine("Hello!");
        }

        public void SetAge(int age)
        {
            _age = age;
        }
    }
}
