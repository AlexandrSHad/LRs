
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Scetch_EntityFramework.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int SchoolClassId { get; set; }
        public SchoolClass SchoolClass { get; set; }
    }
}
