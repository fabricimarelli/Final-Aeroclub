namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Segunda : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aeronaves",
                c => new
                    {
                        ID_aeronave = c.Int(nullable: false, identity: true),
                        matricula = c.String(),
                        marca = c.String(),
                        modelo = c.String(),
                        fechaFabric = c.DateTime(nullable: false),
                        taquimetro = c.Decimal(nullable: false, precision: 18, scale: 2),
                        tarifaHora = c.Decimal(nullable: false, precision: 18, scale: 2),
                        enServicio = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID_aeronave);
            
            CreateTable(
                "dbo.Licencias",
                c => new
                    {
                        ID_Licencia = c.Int(nullable: false, identity: true),
                        nombreLicencia = c.String(),
                        descripLicencia = c.String(),
                    })
                .PrimaryKey(t => t.ID_Licencia);
            
            AddColumn("dbo.Socios", "fechaAdmision", c => c.DateTime(nullable: false));
            AddColumn("dbo.Socios", "fechaNacimiento", c => c.DateTime(nullable: false));
            AddColumn("dbo.Socios", "fotoPersona", c => c.Binary());
            AddColumn("dbo.Socios", "vencimientoCMA", c => c.DateTime());
            AddColumn("dbo.Usuarios", "socio_ID_socio", c => c.Int());
            CreateIndex("dbo.Usuarios", "socio_ID_socio");
            AddForeignKey("dbo.Usuarios", "socio_ID_socio", "dbo.Socios", "ID_socio");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuarios", "socio_ID_socio", "dbo.Socios");
            DropIndex("dbo.Usuarios", new[] { "socio_ID_socio" });
            DropColumn("dbo.Usuarios", "socio_ID_socio");
            DropColumn("dbo.Socios", "vencimientoCMA");
            DropColumn("dbo.Socios", "fotoPersona");
            DropColumn("dbo.Socios", "fechaNacimiento");
            DropColumn("dbo.Socios", "fechaAdmision");
            DropTable("dbo.Licencias");
            DropTable("dbo.Aeronaves");
        }
    }
}
