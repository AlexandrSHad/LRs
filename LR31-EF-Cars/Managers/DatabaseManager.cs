using LR31_EF_Cars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR31_EF_Cars.Managers
{
    public class DatabaseManager : IDatabaseManager
    {
        private AppDataContext _context;

        public DatabaseManager()
        {
            _context = new AppDataContext();
        }

        public List<Brand> ShowBrands()
        {
            return _context.Brands.ToList();
        }

        public List<Car> ShowCars()
        {
            return _context.Cars.ToList();
        }

        public List<CarOwner> ShowOwners()
        {
            return _context.CarOwners.Include("Owner").Include("Car").Include("Car.Brand").ToList();
        }
    }
}
