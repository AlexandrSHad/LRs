namespace LR31_EF_Cars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TypeToBodyType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "BodyType", c => c.Int(nullable: false));
            DropColumn("dbo.Cars", "Type");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cars", "Type", c => c.Int(nullable: false));
            DropColumn("dbo.Cars", "BodyType");
        }
    }
}
