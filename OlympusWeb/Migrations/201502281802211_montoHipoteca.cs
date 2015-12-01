namespace OlympusWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class montoHipoteca : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Hipoteca", "Monto", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Hipoteca", "Monto");
        }
    }
}
