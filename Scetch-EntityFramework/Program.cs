using Scetch_EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scetch_EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                var sc = new SchoolClass() { Name = "7A" };

                context.SchoolClasses.Add(sc);
                context.SaveChanges();

                //var scs = context.SchoolClasses.ToList();
                //foreach (var s in scs)
                //{
                //    Console.WriteLine(s.Name);
                //}

                //var subjects = context.Subjects.ToList();
                //foreach (var subj in subjects)
                //{
                //    Console.WriteLine(subj.Name);
                //}
            }

            Console.ReadLine();
        }
    }
}
