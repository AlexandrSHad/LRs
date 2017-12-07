using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR30_ADO_SQL
{
    class DbStudentsManager : IStudentsManager
    {
        SqlConnection _connection;

        public DbStudentsManager(SqlConnection connection)
        {
            _connection = connection ?? throw new ArgumentNullException(nameof(connection));
        }

        public void AddStudent(Student student)
        {
            try
            {
                _connection.Open();

                string commandText =
                    @"INSERT INTO Students (FirstName, LastName, Age)
                      VALUES (@FirstName, @LastName, @Age)";

                using (var command = new SqlCommand(commandText, _connection))
                {
                    command.Parameters.AddWithValue("FirstName", student.FirstName);
                    command.Parameters.AddWithValue("LastName", student.LastName);
                    command.Parameters.AddWithValue("Age", student.Age);
                    command.ExecuteNonQuery();
                }
            }
            finally
            {
                _connection.Close();
            }
        }

        public Student GetStudent(int id)
        {
            Student student = null;

            try
            {
                _connection.Open();
                string commandText =
                    @"SELECT Id, FirstName, LastName, Age
                      FROM Students
                      WHERE Id = @Id";

                using (var command = new SqlCommand(commandText, _connection))
                {
                    command.Parameters.AddWithValue("Id", id);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            student = new Student(
                                reader.GetInt32(0),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetInt32(3)
                            );
                        }
                    }
                }
            }
            finally
            {
                _connection.Close();
            }

            return student;
        }

        public List<Student> GetStudents()
        {
            var students = new List<Student>();

            try
            {
                _connection.Open();
                using (var command = new SqlCommand(@"SELECT Id, FirstName, LastName, Age FROM Students", _connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var student = new Student(
                                reader.GetInt32(0),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetInt32(3)
                            );

                            students.Add(student);
                        }
                    }
                }
            }
            finally
            {
                _connection.Close();
            }

            return students;
        }

        public void RemoveStudent(int id)
        {
            try
            {
                _connection.Open();

                string commandText =
                    @"DELETE Students
                      WHERE Id = @Id";

                using (var command = new SqlCommand(commandText, _connection))
                {
                    command.Parameters.AddWithValue("Id", id);
                    command.ExecuteNonQuery();
                }
            }
            finally
            {
                _connection.Close();
            }
        }

        public void UpdateStudent(int id, string columnName, object value)
        {
            try
            {
                _connection.Open();

                var sb = new StringBuilder();
                sb.Append("UPDATE Students ");
                sb.AppendFormat("SET {0} = @Value ", columnName);
                sb.Append("WHERE Id = @Id");

                using (var command = new SqlCommand(sb.ToString(), _connection))
                {
                    command.Parameters.AddWithValue("Value", value);
                    command.Parameters.AddWithValue("Id", id);
                    command.ExecuteNonQuery();
                }
            }
            finally
            {
                _connection.Close();
            }
        }
    }
}
