namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mantenimiento : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Mantenimientoes",
                c => new
                    {
                        ID_mantenimiento = c.Int(nullable: false, identity: true),
                        fechaInicio = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        fechaFin = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        trabajos = c.String(),
                        estado = c.String(),
                        taqFuturo = c.Decimal(nullable: false, precision: 18, scale: 2),
                        aeronave_ID_aeronave = c.Int(),
                    })
                .PrimaryKey(t => t.ID_mantenimiento)
                .ForeignKey("dbo.Aeronaves", t => t.aeronave_ID_aeronave)
                .Index(t => t.aeronave_ID_aeronave);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Mantenimientoes", "aeronave_ID_aeronave", "dbo.Aeronaves");
            DropIndex("dbo.Mantenimientoes", new[] { "aeronave_ID_aeronave" });
            DropTable("dbo.Mantenimientoes");
        }
    }
}
