namespace AirScheduler.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateAccountTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO AccountTypes (Id, Name) VALUES (1, 'Basic')");
            Sql("INSERT INTO AccountTypes (Id, Name) VALUES (2, 'Admin')");
        }
        
        public override void Down()
        {
        }
    }
}
