namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _140523 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reservas", "fecha", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reservas", "fecha");
        }
    }
}
