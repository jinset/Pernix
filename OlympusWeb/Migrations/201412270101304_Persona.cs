namespace OlympusWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Persona : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Inversionistas", "PersonatId", c => c.Int(nullable: false));
            DropColumn("dbo.Inversionistas", "ContactId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Inversionistas", "ContactId", c => c.Int(nullable: false));
            DropColumn("dbo.Inversionistas", "PersonatId");
        }
    }
}
