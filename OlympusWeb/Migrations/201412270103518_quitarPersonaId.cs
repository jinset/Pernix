namespace OlympusWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class quitarPersonaId : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Inversionistas", "PersonatId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Inversionistas", "PersonatId", c => c.Int(nullable: false));
        }
    }
}
