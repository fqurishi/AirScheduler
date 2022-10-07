namespace AirScheduler.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEmployerId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "EmployerId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "EmployerId");
        }
    }
}
