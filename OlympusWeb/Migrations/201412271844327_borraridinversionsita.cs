namespace OlympusWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class borraridinversionsita : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "InversionistaId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "InversionistaId", c => c.Int(nullable: false));
        }
    }
}
