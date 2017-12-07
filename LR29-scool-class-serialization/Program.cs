using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace LR29_scool_class_serialization
{
    class Program
    {
        private static List<ScoolClass> _scoolClasses;

        static void Main(string[] args)
        {
            var scm = new ScoolClassesManager("data.xml");

            do
            {
                Console.WriteLine();
                Console.WriteLine("Available commands:");
                Console.WriteLine("  class list");
                Console.WriteLine("  class students <Form>");
                Console.WriteLine("  class students add <ToForm> <LastName> <FirstName>");
                Console.WriteLine("  exit");

                Console.WriteLine();
                Console.Write("command> ");

                string command = Console.ReadLine();

                if (command == "")
                {
                    continue;
                }

                string[] commandParams = command.Split(' ');

                if (commandParams[0] == "class")
                {
                    if (commandParams[1] == "list")
                    {
                        Console.WriteLine("Classes list:");

                        var scList = scm.GetClasses();
                        foreach (var sc in scList)
                        {
                            Console.WriteLine(sc);
                        }
                    }
                    else if (commandParams[1] == "students")
                    {
                        if (commandParams[2] == "add")
                        {
                            var student = new Student(commandParams[5], commandParams[4]);
                            scm.AddStudent(commandParams[3], student);
                        }
                        else
                        {
                            string form = commandParams[2];
                            var sc = scm.GetClass(form);

                            if (sc != null)
                            {
                                if (sc.Students.Count > 0)
                                {
                                    Console.WriteLine($"Students of {form} class:");
                                    foreach (var s in sc.Students)
                                    {
                                        Console.WriteLine("    " + s);
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("There are no students.");
                                }
                            }
                        }
                    }
                }
                else if (commandParams[0] == "exit")
                {
                    return;
                }

            } while (true);


            //var sc1 = new ScoolClass();
            //sc1.Form = "5A";
            //sc1.Subjects.Add(new Subject("Mathematic"));
            //sc1.Subjects.Add(new Subject("English"));
            //sc1.Subjects.Add(new Subject("Physics"));

            //sc1.Students.Add(new Student("Vasya", "Pupkin"));
            //sc1.Students.Add(new Student("Ivan", "Ivanov"));

            //var sc2 = new ScoolClass();
            //sc2.Form = "7B";
            //sc2.Subjects.Add(new Subject("English"));
            //sc2.Subjects.Add(new Subject("Biology"));

            //sc2.Students.Add(new Student("Petro", "Zabor"));
            //sc2.Students.Add(new Student("Mykola", "Drovenyaka"));

            //var scList = new List<ScoolClass>();
            //scList.Add(sc1);
            //scList.Add(sc2);

            //using (var dataStream = new StreamWriter("data.xml"))
            //{
            //    var xmlSerializer = new XmlSerializer(typeof(List<ScoolClass>));
            //    xmlSerializer.Serialize(dataStream, scList);
            //}

            //Console.ReadLine();
        }
    }
}
