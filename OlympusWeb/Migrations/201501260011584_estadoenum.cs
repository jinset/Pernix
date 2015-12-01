namespace OlympusWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class estadoenum : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Abogado", "estado");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Abogado", "estado", c => c.Boolean(nullable: false));
        }
    }
}
