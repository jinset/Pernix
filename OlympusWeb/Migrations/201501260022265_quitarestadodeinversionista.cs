namespace OlympusWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class quitarestadodeinversionista : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "Estado");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Estado", c => c.Boolean(nullable: false));
        }
    }
}
