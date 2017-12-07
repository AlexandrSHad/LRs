namespace LR31_EF_Cars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddednewpropertytoCar : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "EngineCapacity", c => c.Double(nullable: false));
            AddColumn("dbo.Cars", "EngineHorsePower", c => c.Int(nullable: false));
            AddColumn("dbo.Cars", "Type", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "Type");
            DropColumn("dbo.Cars", "EngineHorsePower");
            DropColumn("dbo.Cars", "EngineCapacity");
        }
    }
}
