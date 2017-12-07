using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR31_EF_Cars.Models
{
    public class Car
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public string Model { get; set; }
        public double EngineCapacity { get; set; }
        public int EngineHorsePower { get; set; }
        public BodyType BodyType { get; set; }
    }
}
