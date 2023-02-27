namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class primea : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aeronaves",
                c => new
                    {
                        ID_aeronave = c.Int(nullable: false, identity: true),
                        matricula = c.String(),
                        marcaModelo = c.String(),
                        taquimetro = c.Decimal(nullable: false, precision: 18, scale: 2),
                        tarifaHora = c.Decimal(nullable: false, precision: 18, scale: 2),
                        enServicio = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID_aeronave);
            
            CreateTable(
                "dbo.Licencias",
                c => new
                    {
                        ID_licencia = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        Piloto_ID_socio = c.Int(),
                    })
                .PrimaryKey(t => t.ID_licencia)
                .ForeignKey("dbo.Socios", t => t.Piloto_ID_socio)
                .Index(t => t.Piloto_ID_socio);
            
            CreateTable(
                "dbo.Socios",
                c => new
                    {
                        ID_socio = c.Int(nullable: false, identity: true),
                        fechaAdmision = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        nombre = c.String(),
                        apellido = c.String(),
                        DNI = c.Int(nullable: false),
                        fechaNacimiento = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        domicilio = c.String(),
                        celular = c.String(),
                        email = c.String(),
                        fotoPersona = c.Binary(),
                        esPiloto = c.Boolean(),
                        horasVoladas = c.Decimal(precision: 18, scale: 2),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ID_socio);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        ID_usuario = c.Int(nullable: false, identity: true),
                        nombreUsuario = c.String(),
                        email = c.String(),
                        admin = c.Boolean(nullable: false),
                        password = c.String(),
                        socio_ID_socio = c.Int(),
                    })
                .PrimaryKey(t => t.ID_usuario)
                .ForeignKey("dbo.Socios", t => t.socio_ID_socio)
                .Index(t => t.socio_ID_socio);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuarios", "socio_ID_socio", "dbo.Socios");
            DropForeignKey("dbo.Licencias", "Piloto_ID_socio", "dbo.Socios");
            DropIndex("dbo.Usuarios", new[] { "socio_ID_socio" });
            DropIndex("dbo.Licencias", new[] { "Piloto_ID_socio" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Socios");
            DropTable("dbo.Licencias");
            DropTable("dbo.Aeronaves");
        }
    }
}
