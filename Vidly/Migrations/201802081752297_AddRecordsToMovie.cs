namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRecordsToMovie : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies(MovieName) VALUES('Shrek')");
            Sql("INSERT INTO Movies(MovieName) VALUES('Titanic')");
        }
        
        public override void Down()
        {
        }
    }
}
