namespace OlympusWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tipoFoto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FotosPropiedad", "Tipo", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.FotosPropiedad", "Tipo");
        }
    }
}
