namespace AirScheduler.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAccountType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccountTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Employees", "AccountType_Id", c => c.Byte());
            CreateIndex("dbo.Employees", "AccountType_Id");
            AddForeignKey("dbo.Employees", "AccountType_Id", "dbo.AccountTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "AccountType_Id", "dbo.AccountTypes");
            DropIndex("dbo.Employees", new[] { "AccountType_Id" });
            DropColumn("dbo.Employees", "AccountType_Id");
            DropTable("dbo.AccountTypes");
        }
    }
}
