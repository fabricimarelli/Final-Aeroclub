namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fechaConfig : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Aeronaves", "fechaFabric", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Socios", "fechaAdmision", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Socios", "fechaNacimiento", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Socios", "vencimientoCMA", c => c.DateTime(precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Socios", "vencimientoCMA", c => c.DateTime());
            AlterColumn("dbo.Socios", "fechaNacimiento", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Socios", "fechaAdmision", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Aeronaves", "fechaFabric", c => c.DateTime(nullable: false));
        }
    }
}
