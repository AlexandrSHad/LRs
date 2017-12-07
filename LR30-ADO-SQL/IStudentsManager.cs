using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR30_ADO_SQL
{
    public interface IStudentsManager
    {
        void AddStudent(Student student);
        Student GetStudent(int id);
        List<Student> GetStudents();
        void RemoveStudent(int id);
        void UpdateStudent(int id, string columnName, object value);
    }
}
