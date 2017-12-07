using System;

namespace LR14_event_teacher_student
{
    public class Student
    {
        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void GoToClass(Teacher teacher)
        {
            teacher.OnTeach -= OnTeach;
            teacher.OnTeach += OnTeach;
        }

        public void GoFromClass(Teacher teacher)
        {
            teacher.OnTeach -= OnTeach;
        }

        private void OnTeach(object sender, EventArgs e)
        {
            var teacher = sender as Teacher;

            if (sender != null)
            {
                Console.WriteLine("{0} {1} is present on {2} lesson. Teacher is {3} {4}.",
                    FirstName,
                    LastName,
                    teacher.Subject,
                    teacher.FirstName,
                    teacher.LastName);
            }
        }
    }
}
