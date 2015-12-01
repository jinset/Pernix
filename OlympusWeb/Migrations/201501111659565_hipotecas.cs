namespace OlympusWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hipotecas : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.FotosPropiedad", "File", c => c.Binary());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.FotosPropiedad", "File", c => c.Byte(nullable: false));
        }
    }
}
