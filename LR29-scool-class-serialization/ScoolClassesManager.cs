using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LR29_scool_class_serialization
{
    public class ScoolClassesManager
    {
        private string _dataFilePath;
        private List<ScoolClass> _scoolClasses = new List<ScoolClass>();

        public ScoolClassesManager(string dataFilePath)
        {
            _dataFilePath = dataFilePath;
            Load();
        }

        public void AddStudent(string form, Student student)
        {
            var sc = GetClass(form);
            sc.Students.Add(student);
            Save();
        }

        public ScoolClass GetClass(string form)
        {
            return _scoolClasses.FirstOrDefault((sc) => sc.Form == form);
        }

        public List<ScoolClass> GetClasses()
        {
            return _scoolClasses;
        }

        private void Load()
        {
            using (var dataStream = new StreamReader("data.xml"))
            {
                var xmlSerializer = new XmlSerializer(typeof(List<ScoolClass>));
                _scoolClasses = (List<ScoolClass>)xmlSerializer.Deserialize(dataStream);
            }
        }

        private void Save()
        {
            using (var dataStream = new StreamWriter("data.xml"))
            {
                var xmlSerializer = new XmlSerializer(typeof(List<ScoolClass>));
                xmlSerializer.Serialize(dataStream, _scoolClasses);
            }
        }
    }
}
