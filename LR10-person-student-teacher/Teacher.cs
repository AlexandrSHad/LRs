using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR10_person_student_teacher
{
    public class Teacher : Person
    {
        private string _subject;

        public void Explain()
        {
            Console.WriteLine("Explanation begins.");
        }
    }
}
