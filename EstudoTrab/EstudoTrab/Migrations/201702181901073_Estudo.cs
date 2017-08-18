namespace EstudoTrab.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Estudo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.clientes",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 50),
                        idade = c.Short(nullable: false),
                        cpf = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.clientes");
        }
    }
}
