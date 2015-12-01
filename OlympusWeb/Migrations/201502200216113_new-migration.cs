namespace OlympusWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newmigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Persona", "Nombre", c => c.String(nullable: false));
            AlterColumn("dbo.Persona", "Apellido", c => c.String(nullable: false));
            AlterColumn("dbo.Persona", "Identificacion", c => c.String(nullable: false));
            AlterColumn("dbo.Persona", "Telefono", c => c.String(nullable: false));
            AlterColumn("dbo.Persona", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Persona", "Email", c => c.String());
            AlterColumn("dbo.Persona", "Telefono", c => c.String());
            AlterColumn("dbo.Persona", "Identificacion", c => c.String());
            AlterColumn("dbo.Persona", "Apellido", c => c.String());
            AlterColumn("dbo.Persona", "Nombre", c => c.String());
        }
    }
}
