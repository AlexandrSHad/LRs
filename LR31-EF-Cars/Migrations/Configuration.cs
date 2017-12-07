namespace LR31_EF_Cars.Migrations
{
    using LR31_EF_Cars.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LR31_EF_Cars.AppDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "LR31_EF_Cars.AppDataContext";
        }

        protected override void Seed(LR31_EF_Cars.AppDataContext context)
        {
            var bmw = new Brand() { Name = "BMW" };
            var audi = new Brand() { Name = "Audi" };

            context.Brands.AddOrUpdate(x => x.Name, bmw, audi);

            var q5 = new Car() { Model = "Q5", Brand = audi, BodyType = BodyType.SUV, EngineCapacity = 3.2, EngineHorsePower = 270 };
            var a6 = new Car() { Model = "A6", Brand = audi, BodyType = BodyType.Sedan, EngineCapacity = 2.5, EngineHorsePower = 182 };
            var z4 = new Car() { Model = "Z4", Brand = bmw, BodyType = BodyType.Cabrio, EngineCapacity = 4.0, EngineHorsePower = 380 };
            var x1 = new Car() { Model = "X1", Brand = bmw, BodyType = BodyType.Hatchback, EngineCapacity = 2.1, EngineHorsePower = 107 };

            context.Cars.AddOrUpdate(x => x.Model, q5, a6, z4, x1);

            var bob = new Owner() { Name = "Bob", IsMain = false };
            var ron = new Owner() { Name = "Ron", IsMain = false };

            context.Owners.AddOrUpdate(x => x.Name, bob, ron);

            context.CarOwners.Add(new CarOwner() { Car = q5, Owner = bob } );
            context.CarOwners.Add(new CarOwner() { Car = a6, Owner = bob });

            context.SaveChanges();
        }
    }
}
