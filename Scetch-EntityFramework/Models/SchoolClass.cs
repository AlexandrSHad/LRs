using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scetch_EntityFramework.Models
{
    public class SchoolClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; }
        public List<Subject> Subjects { get; set; }
    }
}
