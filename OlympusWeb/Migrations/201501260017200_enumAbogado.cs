namespace OlympusWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class enumAbogado : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Abogado", "Estado", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Abogado", "Estado");
        }
    }
}
