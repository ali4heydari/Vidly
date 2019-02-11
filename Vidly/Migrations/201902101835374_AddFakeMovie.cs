namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFakeMovie : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO [aspnet-Vidly-2019-02-11].dbo.Movies (Name, GenreId, NumberInStock, ReleaseDate, DateAdded) VALUES ('Titanic', 1, 33, CONVERT(DATETIME,'30/12/2019',103), CURRENT_TIMESTAMP)");
            Sql("INSERT INTO [aspnet-Vidly-2019-02-11].dbo.Movies (Name, GenreId, NumberInStock, ReleaseDate, DateAdded) VALUES ('Marmoolak', 2, 32, CONVERT(DATETIME,'11/11/2010',103), CURRENT_TIMESTAMP)");
            Sql("INSERT INTO [aspnet-Vidly-2019-02-11].dbo.Movies (Name, GenreId, NumberInStock, ReleaseDate, DateAdded) VALUES ('MadMax', 3, 1, CONVERT(DATETIME,'20/10/2012',103), CURRENT_TIMESTAMP)");
            Sql("INSERT INTO [aspnet-Vidly-2019-02-11].dbo.Movies (Name, GenreId, NumberInStock, ReleaseDate, DateAdded) VALUES ('Venom', 4, 43, CONVERT(DATETIME,'12/01/2013',103), CURRENT_TIMESTAMP)");
            Sql("INSERT INTO [aspnet-Vidly-2019-02-11].dbo.Movies (Name, GenreId, NumberInStock, ReleaseDate, DateAdded) VALUES ('StarWars', 5, 234, CONVERT(DATETIME,'13/02/2000',103), CURRENT_TIMESTAMP)");
            Sql("INSERT INTO [aspnet-Vidly-2019-02-11].dbo.Movies (Name, GenreId, NumberInStock, ReleaseDate, DateAdded) VALUES ('EkhrajiHa', 1, 2222, CONVERT(DATETIME,'01/09/2012',103), CURRENT_TIMESTAMP)");
            Sql("INSERT INTO [aspnet-Vidly-2019-02-11].dbo.Movies (Name, GenreId, NumberInStock, ReleaseDate, DateAdded) VALUES ('Madaar', 2, 3546, CONVERT(DATETIME,'03/07/2015',103), CURRENT_TIMESTAMP)");
            Sql("INSERT INTO [aspnet-Vidly-2019-02-11].dbo.Movies (Name, GenreId, NumberInStock, ReleaseDate, DateAdded) VALUES ('Soleyman', 3, 2, CONVERT(DATETIME,'22/12/2014',103), CURRENT_TIMESTAMP)");

        }
        
        public override void Down()
        {
        }
    }
}
