namespace OlympusWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NombreTablaAbogado : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Abogadoes", newName: "Abogado");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Abogado", newName: "Abogadoes");
        }
    }
}
