namespace OlympusWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Profileviews : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Estado", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Estado");
        }
    }
}
