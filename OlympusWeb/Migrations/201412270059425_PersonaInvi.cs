namespace OlympusWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PersonaInvi : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Inversionistas",
                c => new
                    {
                        InversionistaId = c.Int(nullable: false, identity: true),
                        ContactId = c.Int(nullable: false),
                        MontoInvertir = c.Int(nullable: false),
                        TasaInteres = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Persona_PersonaId = c.Int(),
                    })
                .PrimaryKey(t => t.InversionistaId)
                .ForeignKey("dbo.Personas", t => t.Persona_PersonaId)
                .Index(t => t.Persona_PersonaId);
            
            CreateTable(
                "dbo.Personas",
                c => new
                    {
                        PersonaId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Identificacion = c.String(),
                        Telefono = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.PersonaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Inversionistas", "Persona_PersonaId", "dbo.Personas");
            DropIndex("dbo.Inversionistas", new[] { "Persona_PersonaId" });
            DropTable("dbo.Personas");
            DropTable("dbo.Inversionistas");
        }
    }
}
