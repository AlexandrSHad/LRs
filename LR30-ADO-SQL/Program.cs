using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR30_ADO_SQL
{
    // Command examples:
    //   students 1 set age 10
    //   students 1 set firstName Vasyl
    //   students add Zaporogets Semen 45
    //   students remove 3

    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = ConfigurationManager.AppSettings.Get("ConnectionString");
            var connection = new SqlConnection(connectionString);

            var sm = new DbStudentsManager(connection);

            do
            {
                Console.WriteLine();
                Console.WriteLine("Available commands:");
                Console.WriteLine("  students list");
                Console.WriteLine("  students <Id>");
                Console.WriteLine("  students add <LastName> <FirstName> <Age>");
                Console.WriteLine("  students remove <Id>");
                Console.WriteLine("  students <Id> set <PropertyName> <Value>");
                Console.WriteLine("  exit");

                Console.WriteLine();
                Console.Write("command> ");

                string command = Console.ReadLine();

                if (command == "")
                {
                    continue;
                }

                string[] commandParams = command.Split(' ');

                if (commandParams[0] == "students")
                {
                    if (commandParams.Length == 2)
                    {

                        if (commandParams[1] == "list")
                        {
                            Console.WriteLine("Students list:");

                            var sl = sm.GetStudents();

                            foreach (var st in sl)
                            {
                                Console.WriteLine("  " + st);
                            }
                        }
                        else
                        {
                            int id = int.Parse(commandParams[1]);
                            var student = sm.GetStudent(id);

                            if (student != null)
                            {
                                Console.WriteLine("Student info:");
                                Console.WriteLine("  LastName:  {0}", student.LastName);
                                Console.WriteLine("  FirstName: {0}", student.FirstName);
                                Console.WriteLine("  Age:       {0}", student.Age);
                                Console.WriteLine("  ID:        {0}", student.Id);
                            }
                        }
                    }
                    else
                    {
                        if (commandParams[1] == "add")
                        {
                            int id = int.Parse(commandParams[4]);
                            var student = new Student(
                                commandParams[3],
                                commandParams[2],
                                id
                            );
                            sm.AddStudent(student);
                        }
                        else if (commandParams[1] == "remove")
                        {
                            int id = int.Parse(commandParams[2]);
                            sm.RemoveStudent(id);
                        }
                        else if (commandParams[2] == "set")
                        {
                            int id = int.Parse(commandParams[1]);
                            string propertyName = commandParams[3];
                            //if (propertyName.ToLower() == "age")
                            //{
                            //    int age = int.Parse(commandParams[4]);
                            //    sm.UpdateStudent(id, propertyName, age);
                            //}
                            //else if (propertyName.ToLower() == "firstname")
                            //{
                            //    sm.UpdateStudent(id, propertyName, commandParams[4]);
                            //}
                            //else if (propertyName.ToLower() == "lastname")
                            //{
                            //    int age = int.Parse(commandParams[4]);
                            //    sm.UpdateStudent(id, propertyName, commandParams[4]);
                            //}

                            string value = commandParams[4];
                            sm.UpdateStudent(id, propertyName, value);
                        }
                    }
                }
                else if (commandParams[0] == "exit")
                {
                    return;
                }

            } while (true);
        }
    }
}
