namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipType1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (SignUpFee, DurationInMonths, DiscountRate) VALUES (0, 0, 0)");
            Sql("INSERT INTO MembershipTypes (SignUpFee, DurationInMonths, DiscountRate) VALUES (30, 1, 10)");
            Sql("INSERT INTO MembershipTypes (SignUpFee, DurationInMonths, DiscountRate) VALUES (90, 3, 15)");
            Sql("INSERT INTO MembershipTypes (SignUpFee, DurationInMonths, DiscountRate) VALUES (300, 12, 20)");
            Sql("UPDATE MembershipTypes set name = 'Pay as You Go' where DurationInMonths = '0'");
            Sql("UPDATE MembershipTypes set name = 'Monthly' where DurationInMonths = '1'");
            Sql("UPDATE MembershipTypes set name = 'Quarterly' where DurationInMonths = '3'");
            Sql("UPDATE MembershipTypes set name = 'Annually' where DurationInMonths = '12'");
        }

        public override void Down()
        {
        }
    }
}
