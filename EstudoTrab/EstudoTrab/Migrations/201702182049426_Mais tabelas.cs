namespace EstudoTrab.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Maistabelas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alunoes",
                c => new
                    {
                        AlunoId = c.Long(nullable: false, identity: true),
                        nome = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.AlunoId);
            
            CreateTable(
                "dbo.Contas",
                c => new
                    {
                        ContaId = c.Long(nullable: false, identity: true),
                        numero = c.Short(nullable: false),
                        saldo = c.Double(nullable: false),
                        limite = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ContaId);
            
            CreateTable(
                "dbo.Editoras",
                c => new
                    {
                        EditoraId = c.Long(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 30),
                        email = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.EditoraId);
            
            CreateTable(
                "dbo.Livroes",
                c => new
                    {
                        LivroId = c.Long(nullable: false, identity: true),
                        titulo = c.String(nullable: false, maxLength: 50),
                        valor = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.LivroId);
            
            AlterColumn("dbo.clientes", "nome", c => c.String(maxLength: 50));
            AlterColumn("dbo.clientes", "cpf", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.clientes", "cpf", c => c.Long(nullable: false));
            AlterColumn("dbo.clientes", "nome", c => c.String(nullable: false, maxLength: 50));
            DropTable("dbo.Livroes");
            DropTable("dbo.Editoras");
            DropTable("dbo.Contas");
            DropTable("dbo.Alunoes");
        }
    }
}
