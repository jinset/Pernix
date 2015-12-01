namespace OlympusWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class enumTodos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Agente", "Estado", c => c.Int());
            AddColumn("dbo.AgenteIns", "Estado", c => c.Int());
            AddColumn("dbo.Hipoteca", "Estado", c => c.Int());
            AddColumn("dbo.Perito", "Estado", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Perito", "Estado");
            DropColumn("dbo.Hipoteca", "Estado");
            DropColumn("dbo.AgenteIns", "Estado");
            DropColumn("dbo.Agente", "Estado");
        }
    }
}
