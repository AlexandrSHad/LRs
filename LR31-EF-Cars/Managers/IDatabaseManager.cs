using LR31_EF_Cars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR31_EF_Cars.Managers
{
    public interface IDatabaseManager
    {
        List<Car> ShowCars();
        List<Brand> ShowBrands();
        List<CarOwner> ShowOwners();
    }
}
