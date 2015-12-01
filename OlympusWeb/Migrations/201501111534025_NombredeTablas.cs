namespace OlympusWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NombredeTablas : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Contratoes", newName: "Contrato");
            RenameTable(name: "dbo.Agentes", newName: "Agente");
            RenameTable(name: "dbo.Personas", newName: "Persona");
            RenameTable(name: "dbo.Hipotecas", newName: "Hipoteca");
            RenameTable(name: "dbo.FotosPropiedads", newName: "FotosPropiedad");
            RenameTable(name: "dbo.Peritoes", newName: "Perito");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Perito", newName: "Peritoes");
            RenameTable(name: "dbo.FotosPropiedad", newName: "FotosPropiedads");
            RenameTable(name: "dbo.Hipoteca", newName: "Hipotecas");
            RenameTable(name: "dbo.Persona", newName: "Personas");
            RenameTable(name: "dbo.Agente", newName: "Agentes");
            RenameTable(name: "dbo.Contrato", newName: "Contratoes");
        }
    }
}
