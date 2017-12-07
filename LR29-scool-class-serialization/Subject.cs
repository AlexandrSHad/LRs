using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR29_scool_class_serialization
{
    [Serializable]
    public class Subject
    {
        public Subject()
        {
            Name = "";
        }

        public Subject(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
