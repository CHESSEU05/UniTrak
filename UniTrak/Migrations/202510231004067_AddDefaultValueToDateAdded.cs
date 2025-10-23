namespace UniTrak.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDefaultValueToDateAdded : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE Courses ADD CONSTRAINT DefaultDateAdded DEFAULT CAST(GETDATE() AS DATE) FOR DateAdded");
        }
        
        public override void Down()
        {
        }
    }
}
