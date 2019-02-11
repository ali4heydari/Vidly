namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFakeCustomer : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO [aspnet-Vidly-2019-02-11].dbo.Customers (Name, IsSubscribedToNewsLetter, MembershipTypeId, Birthdate) values ('Ali Heydari', 1, 1, CONVERT(DATETIME,'30/01/1997',103))");
            Sql("INSERT INTO [aspnet-Vidly-2019-02-11].dbo.Customers (Name, IsSubscribedToNewsLetter, MembershipTypeId, Birthdate) values ('Haniye Shirazi', 1, 1, CONVERT(DATETIME,'18/03/1996',103))");
            Sql("INSERT INTO [aspnet-Vidly-2019-02-11].dbo.Customers (Name, IsSubscribedToNewsLetter, MembershipTypeId, Birthdate) values ('Hossein Mohammadi', 0, 1, CONVERT(DATETIME,'08/03/2000',103))");
            Sql("INSERT INTO [aspnet-Vidly-2019-02-11].dbo.Customers (Name, IsSubscribedToNewsLetter, MembershipTypeId, Birthdate) values ('Ali Ghasemi', 1, 1, CONVERT(DATETIME,'14/04/2001',103))");
            Sql("INSERT INTO [aspnet-Vidly-2019-02-11].dbo.Customers (Name, IsSubscribedToNewsLetter, MembershipTypeId, Birthdate) values ('Mahdi Fadaei', 1, 1, CONVERT(DATETIME,'22/06/2010',103))");
            Sql("INSERT INTO [aspnet-Vidly-2019-02-11].dbo.Customers (Name, IsSubscribedToNewsLetter, MembershipTypeId, Birthdate) values ('Sara Rahmani', 0, 1, CONVERT(DATETIME,'12/12/2012',103))");
            Sql("INSERT INTO [aspnet-Vidly-2019-02-11].dbo.Customers (Name, IsSubscribedToNewsLetter, MembershipTypeId, Birthdate) values ('Samira Sosmari', 0, 1, CONVERT(DATETIME,'21/02/1995',103))");
            Sql("INSERT INTO [aspnet-Vidly-2019-02-11].dbo.Customers (Name, IsSubscribedToNewsLetter, MembershipTypeId, Birthdate) values ('Maryam Talebi', 1, 1, CONVERT(DATETIME,'30/11/1982',103))");

        }
        
        public override void Down()
        {
        }
    }
}
