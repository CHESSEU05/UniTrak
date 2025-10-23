namespace UniTrak.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsSubcribedToNewsletterToStudent : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "IsSubscribedToNewsletter", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "IsSubscribedToNewsletter");
        }
    }
}
