namespace UniTrak.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EnablingBirthDateNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "DoB", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "DoB", c => c.DateTime(nullable: false));
        }
    }
}
