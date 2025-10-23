namespace UniTrak.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipTypeToStudent : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MembershipTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        SignUpFee = c.Byte(nullable: false),
                        DurationInMonths = c.Byte(nullable: false),
                        Discount = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Students", "MembershipTypeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Students", "MembershipTypeId");
            AddForeignKey("dbo.Students", "MembershipTypeId", "dbo.MembershipTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "MembershipTypeId", "dbo.MembershipTypes");
            DropIndex("dbo.Students", new[] { "MembershipTypeId" });
            DropColumn("dbo.Students", "MembershipTypeId");
            DropTable("dbo.MembershipTypes");
        }
    }
}
