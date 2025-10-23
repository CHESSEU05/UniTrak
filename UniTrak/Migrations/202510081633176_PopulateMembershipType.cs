namespace UniTrak.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, Discount) VALUES (1, 0, 0, 0.0)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, Discount) VALUES (2, 30, 1, 0.1)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, Discount) VALUES (3, 90, 3, 0.15)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, Discount) VALUES (4, 300, 12, 0.2)");
        }
        
        public override void Down()
        {
        }
    }
}
