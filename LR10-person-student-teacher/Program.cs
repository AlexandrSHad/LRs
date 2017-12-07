using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR10_person_student_teacher
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Hello();

            Console.WriteLine();

            var student = new Student();
            student.SetAge(21);
            student.Hello();
            student.ShowAge();

            Console.WriteLine();

            var teacher = new Teacher();
            teacher.SetAge(30);
            teacher.Explain();

            Console.WriteLine();
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
