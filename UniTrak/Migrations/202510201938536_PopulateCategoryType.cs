namespace UniTrak.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CategoryTypes (Id, Name, ShortDescription) VALUES (1, 'Computer Science', 'Studies of Information and Computer Technologies')");
            Sql("INSERT INTO CategoryTypes (Id, Name, ShortDescription) VALUES (2, 'Physics', 'Study of the science of the universe')");
            Sql("INSERT INTO CategoryTypes (Id, Name, ShortDescription) VALUES (3, 'Mathematics', 'The science of Logic and Analysis')");
            Sql("INSERT INTO CategoryTypes (Id, Name, ShortDescription) VALUES (4, 'Chemistry', 'Study of science and the reaction of substances')");
            Sql("INSERT INTO CategoryTypes (Id, Name, ShortDescription) VALUES (5, 'Architecture', 'Study of architectural patterns in the construction field')");
        }
        
        public override void Down()
        {
        }
    }
}
