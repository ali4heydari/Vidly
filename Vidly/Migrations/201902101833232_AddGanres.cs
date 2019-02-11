namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGanres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO [aspnet-Vidly-2019-02-11].[dbo].[Genres] (Id, Name) VALUES (1, 'Action')");
            Sql("INSERT INTO [aspnet-Vidly-2019-02-11].[dbo].[Genres] (Id, Name) VALUES (2, 'Thriller')");
            Sql("INSERT INTO [aspnet-Vidly-2019-02-11].[dbo].[Genres] (Id, Name) VALUES (3, 'Family')");
            Sql("INSERT INTO [aspnet-Vidly-2019-02-11].[dbo].[Genres] (Id, Name) VALUES (4, 'Romance')");
            Sql("INSERT INTO [aspnet-Vidly-2019-02-11].[dbo].[Genres] (Id, Name) VALUES (5, 'Comedy')");
        }
        
        public override void Down()
        {
        }
    }
}
