namespace OlympusWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modelos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abogadoes",
                c => new
                    {
                        AbogadoId = c.Int(nullable: false, identity: true),
                        Persona_PersonaId = c.Int(),
                    })
                .PrimaryKey(t => t.AbogadoId)
                .ForeignKey("dbo.Personas", t => t.Persona_PersonaId)
                .Index(t => t.Persona_PersonaId);
            
            CreateTable(
                "dbo.AgenteIns",
                c => new
                    {
                        AgenteInsId = c.Int(nullable: false, identity: true),
                        Persona_PersonaId = c.Int(),
                    })
                .PrimaryKey(t => t.AgenteInsId)
                .ForeignKey("dbo.Personas", t => t.Persona_PersonaId)
                .Index(t => t.Persona_PersonaId);
            
            CreateTable(
                "dbo.Hipotecas",
                c => new
                    {
                        HipotecaId = c.Int(nullable: false, identity: true),
                        NumeroPlano = c.String(),
                        Provincia = c.String(),
                        Distrito = c.String(),
                        Canton = c.String(),
                        GravamenesAnotaciones = c.String(),
                        TipoPropiedad = c.Int(),
                        Persona_PersonaId = c.Int(),
                    })
                .PrimaryKey(t => t.HipotecaId)
                .ForeignKey("dbo.Personas", t => t.Persona_PersonaId)
                .Index(t => t.Persona_PersonaId);
            
            CreateTable(
                "dbo.Peritoes",
                c => new
                    {
                        PeritoId = c.Int(nullable: false, identity: true),
                        Persona_PersonaId = c.Int(),
                    })
                .PrimaryKey(t => t.PeritoId)
                .ForeignKey("dbo.Personas", t => t.Persona_PersonaId)
                .Index(t => t.Persona_PersonaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Peritoes", "Persona_PersonaId", "dbo.Personas");
            DropForeignKey("dbo.Hipotecas", "Persona_PersonaId", "dbo.Personas");
            DropForeignKey("dbo.AgenteIns", "Persona_PersonaId", "dbo.Personas");
            DropForeignKey("dbo.Abogadoes", "Persona_PersonaId", "dbo.Personas");
            DropIndex("dbo.Peritoes", new[] { "Persona_PersonaId" });
            DropIndex("dbo.Hipotecas", new[] { "Persona_PersonaId" });
            DropIndex("dbo.AgenteIns", new[] { "Persona_PersonaId" });
            DropIndex("dbo.Abogadoes", new[] { "Persona_PersonaId" });
            DropTable("dbo.Peritoes");
            DropTable("dbo.Hipotecas");
            DropTable("dbo.AgenteIns");
            DropTable("dbo.Abogadoes");
        }
    }
}
