namespace UniTrak.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReaddCategoryTypreToDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CategoryTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false),
                        ShortDescription = c.String(nullable: false, maxLength: 75),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Courses", "CategoryTypeId");
            AddForeignKey("dbo.Courses", "CategoryTypeId", "dbo.CategoryTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "CategoryTypeId", "dbo.CategoryTypes");
            DropIndex("dbo.Courses", new[] { "CategoryTypeId" });
            DropTable("dbo.CategoryTypes");
        }
    }
}
