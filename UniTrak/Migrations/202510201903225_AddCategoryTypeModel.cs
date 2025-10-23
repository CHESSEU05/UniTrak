namespace UniTrak.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategoryTypeModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false),
                        Title = c.String(nullable: false),
                        CreditValue = c.Byte(nullable: false),
                        DateAdded = c.DateTime(nullable: false),
                        CategoryTypeId = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CategoryTypes", t => t.CategoryTypeId, cascadeDelete: true)
                .Index(t => t.CategoryTypeId);
            
            CreateTable(
                "dbo.CategoryTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false),
                        ShortDescription = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "CategoryTypeId", "dbo.CategoryTypes");
            DropIndex("dbo.Courses", new[] { "CategoryTypeId" });
            DropTable("dbo.CategoryTypes");
            DropTable("dbo.Courses");
        }
    }
}
