namespace OlympusWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inversionistaborrado : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Inversionistas", "Persona_PersonaId", "dbo.Personas");
            DropIndex("dbo.Inversionistas", new[] { "Persona_PersonaId" });
            CreateTable(
                "dbo.Agentes",
                c => new
                    {
                        AgenteId = c.Int(nullable: false, identity: true),
                        CodigoAgente = c.String(),
                        Persona_PersonaId = c.Int(),
                    })
                .PrimaryKey(t => t.AgenteId)
                .ForeignKey("dbo.Personas", t => t.Persona_PersonaId)
                .Index(t => t.Persona_PersonaId);
            
            AddColumn("dbo.AspNetUsers", "InversionistaId", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "MontoInvertir", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "TasaInteres", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropTable("dbo.Inversionistas");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Inversionistas",
                c => new
                    {
                        InversionistaId = c.Int(nullable: false, identity: true),
                        MontoInvertir = c.Int(nullable: false),
                        TasaInteres = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Persona_PersonaId = c.Int(),
                    })
                .PrimaryKey(t => t.InversionistaId);
            
            DropForeignKey("dbo.Agentes", "Persona_PersonaId", "dbo.Personas");
            DropIndex("dbo.Agentes", new[] { "Persona_PersonaId" });
            DropColumn("dbo.AspNetUsers", "TasaInteres");
            DropColumn("dbo.AspNetUsers", "MontoInvertir");
            DropColumn("dbo.AspNetUsers", "InversionistaId");
            DropTable("dbo.Agentes");
            CreateIndex("dbo.Inversionistas", "Persona_PersonaId");
            AddForeignKey("dbo.Inversionistas", "Persona_PersonaId", "dbo.Personas", "PersonaId");
        }
    }
}
