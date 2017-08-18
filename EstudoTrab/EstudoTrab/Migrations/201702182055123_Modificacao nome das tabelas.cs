namespace EstudoTrab.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Modificacaonomedastabelas : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Alunoes", newName: "alunos");
            RenameTable(name: "dbo.Livroes", newName: "livros");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.livros", newName: "Livroes");
            RenameTable(name: "dbo.alunos", newName: "Alunoes");
        }
    }
}
