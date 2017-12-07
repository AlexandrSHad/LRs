using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR29_scool_class_serialization
{
    [Serializable]
    public class ScoolClass
    {
        public List<Subject> Subjects = new List<Subject>();
        public List<Student> Students = new List<Student>();

        public string Form { get; set; }

        public override string ToString()
        {
            return Form;
        }
    }
}
