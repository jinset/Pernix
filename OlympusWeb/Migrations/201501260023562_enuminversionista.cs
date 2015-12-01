namespace OlympusWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class enuminversionista : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Estado", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Estado");
        }
    }
}
