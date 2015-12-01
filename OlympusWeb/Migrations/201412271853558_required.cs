namespace OlympusWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class required : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Agentes", "CodigoAgente", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Agentes", "CodigoAgente", c => c.String());
        }
    }
}
