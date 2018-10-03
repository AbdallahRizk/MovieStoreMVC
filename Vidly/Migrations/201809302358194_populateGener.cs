namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateGener : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Thriller')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Family')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Romance')");
        }
        
        public override void Down()
        {
            
        }
    }
}
