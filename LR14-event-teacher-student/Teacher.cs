using System;

namespace LR14_event_teacher_student
{
    public class Teacher
    {
        public Teacher(string firstName, string lastName, string subject)
        {
            FirstName = firstName;
            LastName = lastName;
            Subject = subject;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }

        public event EventHandler OnTeach;

        public void Teach()
        {
            OnTeach?.Invoke(this, EventArgs.Empty);
        }
    }
}
