using System;

namespace LR14_event_teacher_student
{
    class Program
    {
        static void Main(string[] args)
        {
            var mathTeacher = new Teacher("Olga", "Uchina", "Mathematic");
            var psyTeacher = new Teacher("Mariya", "Ivanova", "Psyhology");
            var phyTeacher = new Teacher("Sergey", "Ovechkin", "Physics");

            var ivanStudent = new Student("Ivan", "Ivanov");
            ivanStudent.GoToClass(mathTeacher);
            ivanStudent.GoToClass(mathTeacher);
            ivanStudent.GoToClass(phyTeacher);
            
            var petroStudent = new Student("Petr", "Sapognikov");
            petroStudent.GoToClass(psyTeacher);

            var vasyaStudent = new Student("Vasiliy", "Trubachev");
            vasyaStudent.GoToClass(phyTeacher);

            Console.WriteLine("{0}:", mathTeacher.Subject);
            mathTeacher.Teach();

            Console.WriteLine();

            Console.WriteLine("{0}:", psyTeacher.Subject);
            psyTeacher.Teach();

            Console.WriteLine();

            Console.WriteLine("{0}:", phyTeacher.Subject);
            phyTeacher.Teach();

            Console.WriteLine();
            Console.WriteLine("Vasiliy Trubachev goes from physics class");

            vasyaStudent.GoFromClass(phyTeacher);

            Console.WriteLine();

            Console.WriteLine("{0}:", phyTeacher.Subject);
            phyTeacher.Teach();

            Console.WriteLine();
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
