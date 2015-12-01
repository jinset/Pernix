namespace OlympusWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class eliminarestados : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Hipoteca", "estado");
            DropColumn("dbo.Perito", "estado");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Perito", "estado", c => c.Boolean(nullable: false));
            AddColumn("dbo.Hipoteca", "estado", c => c.Boolean(nullable: false));
        }
    }
}
