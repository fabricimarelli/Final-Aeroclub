namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PrimerMigracion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Socios",
                c => new
                    {
                        ID_socio = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        apellido = c.String(),
                        DNI = c.Int(nullable: false),
                        domicilio = c.String(),
                        celular = c.String(),
                        email = c.String(),
                        esPiloto = c.Boolean(),
                        horasVoladas = c.Decimal(precision: 18, scale: 2),
                        claseCMA = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ID_socio);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        ID_usuario = c.Int(nullable: false, identity: true),
                        nombreUsuario = c.String(),
                        password = c.String(),
                    })
                .PrimaryKey(t => t.ID_usuario);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuarios");
            DropTable("dbo.Socios");
        }
    }
}
