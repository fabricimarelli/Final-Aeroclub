namespace CONTEXTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tercera : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reservas", "Usuario_ID_usuario", "dbo.Usuarios");
            DropIndex("dbo.Reservas", new[] { "Usuario_ID_usuario" });
            AddColumn("dbo.Reservas", "Piloto_ID_socio", c => c.Int());
            CreateIndex("dbo.Reservas", "Piloto_ID_socio");
            AddForeignKey("dbo.Reservas", "Piloto_ID_socio", "dbo.Socios", "ID_socio");
            DropColumn("dbo.Reservas", "Usuario_ID_usuario");
            DropColumn("dbo.Vueloes", "aterrizajes");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Vueloes", "aterrizajes", c => c.Int(nullable: false));
            AddColumn("dbo.Reservas", "Usuario_ID_usuario", c => c.Int());
            DropForeignKey("dbo.Reservas", "Piloto_ID_socio", "dbo.Socios");
            DropIndex("dbo.Reservas", new[] { "Piloto_ID_socio" });
            DropColumn("dbo.Reservas", "Piloto_ID_socio");
            CreateIndex("dbo.Reservas", "Usuario_ID_usuario");
            AddForeignKey("dbo.Reservas", "Usuario_ID_usuario", "dbo.Usuarios", "ID_usuario");
        }
    }
}
