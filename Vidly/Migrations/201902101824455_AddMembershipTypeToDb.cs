namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddMembershipTypeToDb : DbMigration
    {
        public override void Up()
        {
            Sql(
                "INSERT INTO [aspnet-Vidly-2019-02-11].[dbo].[MembershipTypes] (Id, SignUpFee, DurationInMonths, DiscountRate, Name) VALUES (1, 0, 0, 0, 'Pay as you go')");
            Sql(
                "INSERT INTO [aspnet-Vidly-2019-02-11].[dbo].[MembershipTypes] (Id, SignUpFee, DurationInMonths, DiscountRate, Name) VALUES (2, 30, 1, 10,'Monthly')");
            Sql(
                "INSERT INTO [aspnet-Vidly-2019-02-11].[dbo].[MembershipTypes] (Id, SignUpFee, DurationInMonths, DiscountRate, Name) VALUES (3, 90, 3, 15,'Quarterly')");
            Sql(
                "INSERT INTO [aspnet-Vidly-2019-02-11].[dbo].[MembershipTypes] (Id, SignUpFee, DurationInMonths, DiscountRate, Name) VALUES (4, 300, 12, 20,'Annual')");
        }

        public override void Down()
        {
        }
    }
}