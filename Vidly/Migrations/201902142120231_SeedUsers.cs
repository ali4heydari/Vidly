namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(
                @"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'3906e7c0-8e32-4098-bc26-80ec2ead6de5', N'ali4heydari@gmail.com', 0, N'AEkqma12p8MAZQaesflq6H9F5QNjzfaBk/rIBKMntyVWAULmMnOJYY/AScaJVh6yPg==', N'467ccaff-e22c-4799-9c95-d946fd355743', NULL, 0, 0, NULL, 1, 0, N'ali4heydari@gmail.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd6c9b157-0095-4d2c-8de2-007493fb21d6', N'admin@vidly.com', 0, N'AAfumzdNYFIHE3yTJeAMg+vcrwFabF2wl2ZQJD/c3ikRWdYlf4lEWE+kfjByCZITFQ==', N'58da800c-1740-491c-a662-b32431709d8a', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'11b2c2fb-2bcc-487f-83b0-ddb2a1bbe299', N'CanManageMovies')
                
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd6c9b157-0095-4d2c-8de2-007493fb21d6', N'11b2c2fb-2bcc-487f-83b0-ddb2a1bbe299')");
        }

        public override void Down()
        {
        }
    }
}