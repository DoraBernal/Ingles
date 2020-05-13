namespace Ingles.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        apellido_p = c.String(),
                        apellido_m = c.String(),
                        matricula = c.Int(nullable: false),
                        contraseña = c.String(),
                        nivel = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.usuarios");
        }
    }
}
