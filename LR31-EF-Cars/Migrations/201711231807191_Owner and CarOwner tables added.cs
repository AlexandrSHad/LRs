namespace LR31_EF_Cars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OwnerandCarOwnertablesadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CarOwners",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CarId = c.Int(nullable: false),
                        OwnerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cars", t => t.CarId, cascadeDelete: true)
                .ForeignKey("dbo.Owners", t => t.OwnerId, cascadeDelete: true)
                .Index(t => t.CarId)
                .Index(t => t.OwnerId);
            
            CreateTable(
                "dbo.Owners",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsMain = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CarOwners", "OwnerId", "dbo.Owners");
            DropForeignKey("dbo.CarOwners", "CarId", "dbo.Cars");
            DropIndex("dbo.CarOwners", new[] { "OwnerId" });
            DropIndex("dbo.CarOwners", new[] { "CarId" });
            DropTable("dbo.Owners");
            DropTable("dbo.CarOwners");
        }
    }
}
