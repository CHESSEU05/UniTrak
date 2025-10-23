namespace UniTrak.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCourses : DbMigration
    {
        public override void Up()
        {
            // Befire populating the course, let's reset identity seeding to avoid conflicts
            Sql("DELETE FROM Courses");
            Sql("DBCC CHECKIDENT ('Courses', RESEED, 0)");

            // Insert predefined courses
            Sql("INSERT INTO Courses (Code, Title, CreditValue, CategoryTypeId) VALUES ('CEF440', 'Internet Programming and Mobile Programming', 4, 1)");
            Sql("INSERT INTO Courses (Code, Title, CreditValue, CategoryTypeId) VALUES ('CEF438', 'Advanced Database and Administration', 4, 1)");
            Sql("INSERT INTO Courses (Code, Title, CreditValue, CategoryTypeId) VALUES ('EEF373', 'Digital Electronics II', 3, 2)");
            Sql("INSERT INTO Courses (Code, Title, CreditValue, CategoryTypeId) VALUES ('EEF476', 'Feedback System Laboratory', 3, 2)");
            Sql("INSERT INTO Courses (Code, Title, CreditValue, CategoryTypeId) VALUES ('CEF201', 'Analysis', 4, 3)");
            Sql("INSERT INTO Courses (Code, Title, CreditValue, CategoryTypeId) VALUES ('FET301', 'Probability and Statistics', 3, 3)");
            Sql("INSERT INTO Courses (Code, Title, CreditValue, CategoryTypeId) VALUES ('CPE201', 'Introduction to Petroleum Engineering', 4, 4)");
            Sql("INSERT INTO Courses (Code, Title, CreditValue, CategoryTypeId) VALUES ('CPE203', 'Introduction to Fluid Engineering', 4, 4)");
            Sql("INSERT INTO Courses (Code, Title, CreditValue, CategoryTypeId) VALUES ('CIV219', 'Technical Drawing I', 3, 5)");
            Sql("INSERT INTO Courses (Code, Title, CreditValue, CategoryTypeId) VALUES ('CIV345', 'Engineering Geology and Applied Hydrology', 4, 5)");
        }

        public override void Down()
        {
        }
    }
}
