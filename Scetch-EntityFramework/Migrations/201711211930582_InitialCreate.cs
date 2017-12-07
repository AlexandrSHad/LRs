namespace Scetch_EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SchoolClasses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        SchoolClassId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SchoolClasses", t => t.SchoolClassId, cascadeDelete: true)
                .Index(t => t.SchoolClassId);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SubjectSchoolClasses",
                c => new
                    {
                        Subject_Id = c.Int(nullable: false),
                        SchoolClass_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Subject_Id, t.SchoolClass_Id })
                .ForeignKey("dbo.Subjects", t => t.Subject_Id, cascadeDelete: true)
                .ForeignKey("dbo.SchoolClasses", t => t.SchoolClass_Id, cascadeDelete: true)
                .Index(t => t.Subject_Id)
                .Index(t => t.SchoolClass_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SubjectSchoolClasses", "SchoolClass_Id", "dbo.SchoolClasses");
            DropForeignKey("dbo.SubjectSchoolClasses", "Subject_Id", "dbo.Subjects");
            DropForeignKey("dbo.Students", "SchoolClassId", "dbo.SchoolClasses");
            DropIndex("dbo.SubjectSchoolClasses", new[] { "SchoolClass_Id" });
            DropIndex("dbo.SubjectSchoolClasses", new[] { "Subject_Id" });
            DropIndex("dbo.Students", new[] { "SchoolClassId" });
            DropTable("dbo.SubjectSchoolClasses");
            DropTable("dbo.Subjects");
            DropTable("dbo.Students");
            DropTable("dbo.SchoolClasses");
        }
    }
}
