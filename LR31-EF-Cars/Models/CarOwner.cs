using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR31_EF_Cars.Models
{
    // таблица развязки
    public class CarOwner
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
        public int OwnerId { get; set; }
        public Owner Owner { get; set; }
    }
}
