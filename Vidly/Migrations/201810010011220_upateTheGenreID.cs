namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class upateTheGenreID : DbMigration
    {
        public override void Up()
        {
            Sql("Update Movies SET Genre_Id = 2 WHERE Id = 2");
            Sql("Update Movies SET Genre_Id = 3 WHERE Id = 3");

        }

        public override void Down()
        {
        }
    }
}
