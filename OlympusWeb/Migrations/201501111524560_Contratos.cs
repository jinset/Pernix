namespace OlympusWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Contratos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contratoes",
                c => new
                    {
                        ApplicationUserId = c.String(nullable: false, maxLength: 128),
                        ContratoId = c.Int(nullable: false),
                        Abogado_AbogadoId = c.Int(),
                        Agente_AgenteId = c.Int(),
                        AgenteIns_AgenteInsId = c.Int(),
                        Hipoteca_HipotecaId = c.Int(),
                        Perito_PeritoId = c.Int(),
                    })
                .PrimaryKey(t => new { t.ApplicationUserId, t.ContratoId })
                .ForeignKey("dbo.Abogadoes", t => t.Abogado_AbogadoId)
                .ForeignKey("dbo.Agentes", t => t.Agente_AgenteId)
                .ForeignKey("dbo.AgenteIns", t => t.AgenteIns_AgenteInsId)
                .ForeignKey("dbo.Hipotecas", t => t.Hipoteca_HipotecaId)
                .ForeignKey("dbo.Peritoes", t => t.Perito_PeritoId)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUserId, cascadeDelete: true)
                .Index(t => t.ApplicationUserId)
                .Index(t => t.Abogado_AbogadoId)
                .Index(t => t.Agente_AgenteId)
                .Index(t => t.AgenteIns_AgenteInsId)
                .Index(t => t.Hipoteca_HipotecaId)
                .Index(t => t.Perito_PeritoId);
            
            CreateTable(
                "dbo.FotosPropiedads",
                c => new
                    {
                        FotosPropiedadId = c.Int(nullable: false, identity: true),
                        FileName = c.String(),
                        File = c.Byte(nullable: false),
                        hipoteca_HipotecaId = c.Int(),
                    })
                .PrimaryKey(t => t.FotosPropiedadId)
                .ForeignKey("dbo.Hipotecas", t => t.hipoteca_HipotecaId)
                .Index(t => t.hipoteca_HipotecaId);
            
            AddColumn("dbo.Abogadoes", "estado", c => c.Boolean(nullable: false));
            AddColumn("dbo.Agentes", "estado", c => c.Boolean(nullable: false));
            AddColumn("dbo.AgenteIns", "estado", c => c.Boolean(nullable: false));
            AddColumn("dbo.Hipotecas", "estado", c => c.Boolean(nullable: false));
            AddColumn("dbo.Peritoes", "estado", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contratoes", "ApplicationUserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Contratoes", "Perito_PeritoId", "dbo.Peritoes");
            DropForeignKey("dbo.FotosPropiedads", "hipoteca_HipotecaId", "dbo.Hipotecas");
            DropForeignKey("dbo.Contratoes", "Hipoteca_HipotecaId", "dbo.Hipotecas");
            DropForeignKey("dbo.Contratoes", "AgenteIns_AgenteInsId", "dbo.AgenteIns");
            DropForeignKey("dbo.Contratoes", "Agente_AgenteId", "dbo.Agentes");
            DropForeignKey("dbo.Contratoes", "Abogado_AbogadoId", "dbo.Abogadoes");
            DropIndex("dbo.FotosPropiedads", new[] { "hipoteca_HipotecaId" });
            DropIndex("dbo.Contratoes", new[] { "Perito_PeritoId" });
            DropIndex("dbo.Contratoes", new[] { "Hipoteca_HipotecaId" });
            DropIndex("dbo.Contratoes", new[] { "AgenteIns_AgenteInsId" });
            DropIndex("dbo.Contratoes", new[] { "Agente_AgenteId" });
            DropIndex("dbo.Contratoes", new[] { "Abogado_AbogadoId" });
            DropIndex("dbo.Contratoes", new[] { "ApplicationUserId" });
            DropColumn("dbo.Peritoes", "estado");
            DropColumn("dbo.Hipotecas", "estado");
            DropColumn("dbo.AgenteIns", "estado");
            DropColumn("dbo.Agentes", "estado");
            DropColumn("dbo.Abogadoes", "estado");
            DropTable("dbo.FotosPropiedads");
            DropTable("dbo.Contratoes");
        }
    }
}
