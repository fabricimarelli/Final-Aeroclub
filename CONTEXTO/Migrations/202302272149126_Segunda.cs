namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Segunda : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cursoes",
                c => new
                    {
                        ID_curso = c.Int(nullable: false, identity: true),
                        tipoCurso = c.String(),
                        activo = c.Boolean(nullable: false),
                        horasVoladas = c.Decimal(nullable: false, precision: 18, scale: 2),
                        aeronave_ID_aeronave = c.Int(),
                        alumno_ID_socio = c.Int(),
                    })
                .PrimaryKey(t => t.ID_curso)
                .ForeignKey("dbo.Aeronaves", t => t.aeronave_ID_aeronave)
                .ForeignKey("dbo.Socios", t => t.alumno_ID_socio)
                .Index(t => t.aeronave_ID_aeronave)
                .Index(t => t.alumno_ID_socio);
            
            CreateTable(
                "dbo.Reservas",
                c => new
                    {
                        ID_reserva = c.Int(nullable: false, identity: true),
                        desde = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        hasta = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        aeronave_ID_aeronave = c.Int(),
                        Usuario_ID_usuario = c.Int(),
                    })
                .PrimaryKey(t => t.ID_reserva)
                .ForeignKey("dbo.Aeronaves", t => t.aeronave_ID_aeronave)
                .ForeignKey("dbo.Usuarios", t => t.Usuario_ID_usuario)
                .Index(t => t.aeronave_ID_aeronave)
                .Index(t => t.Usuario_ID_usuario);
            
            CreateTable(
                "dbo.Vueloes",
                c => new
                    {
                        ID_vuelo = c.Int(nullable: false, identity: true),
                        taquimSalida = c.Decimal(nullable: false, precision: 18, scale: 2),
                        taquimLlegada = c.Decimal(nullable: false, precision: 18, scale: 2),
                        tiempo = c.Decimal(nullable: false, precision: 18, scale: 2),
                        aterrizajes = c.Int(nullable: false),
                        tarifa = c.Decimal(nullable: false, precision: 18, scale: 2),
                        observaciones = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        aeronave_ID_aeronave = c.Int(),
                        piloto_ID_socio = c.Int(),
                        alumno_ID_socio = c.Int(),
                    })
                .PrimaryKey(t => t.ID_vuelo)
                .ForeignKey("dbo.Aeronaves", t => t.aeronave_ID_aeronave)
                .ForeignKey("dbo.Socios", t => t.piloto_ID_socio)
                .ForeignKey("dbo.Socios", t => t.alumno_ID_socio)
                .Index(t => t.aeronave_ID_aeronave)
                .Index(t => t.piloto_ID_socio)
                .Index(t => t.alumno_ID_socio);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vueloes", "alumno_ID_socio", "dbo.Socios");
            DropForeignKey("dbo.Vueloes", "piloto_ID_socio", "dbo.Socios");
            DropForeignKey("dbo.Vueloes", "aeronave_ID_aeronave", "dbo.Aeronaves");
            DropForeignKey("dbo.Reservas", "Usuario_ID_usuario", "dbo.Usuarios");
            DropForeignKey("dbo.Reservas", "aeronave_ID_aeronave", "dbo.Aeronaves");
            DropForeignKey("dbo.Cursoes", "alumno_ID_socio", "dbo.Socios");
            DropForeignKey("dbo.Cursoes", "aeronave_ID_aeronave", "dbo.Aeronaves");
            DropIndex("dbo.Vueloes", new[] { "alumno_ID_socio" });
            DropIndex("dbo.Vueloes", new[] { "piloto_ID_socio" });
            DropIndex("dbo.Vueloes", new[] { "aeronave_ID_aeronave" });
            DropIndex("dbo.Reservas", new[] { "Usuario_ID_usuario" });
            DropIndex("dbo.Reservas", new[] { "aeronave_ID_aeronave" });
            DropIndex("dbo.Cursoes", new[] { "alumno_ID_socio" });
            DropIndex("dbo.Cursoes", new[] { "aeronave_ID_aeronave" });
            DropTable("dbo.Vueloes");
            DropTable("dbo.Reservas");
            DropTable("dbo.Cursoes");
        }
    }
}
