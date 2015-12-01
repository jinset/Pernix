namespace OlympusWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class eliminarestados2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Agente", "estado");
            DropColumn("dbo.AgenteIns", "estado");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AgenteIns", "estado", c => c.Boolean(nullable: false));
            AddColumn("dbo.Agente", "estado", c => c.Boolean(nullable: false));
        }
    }
}
