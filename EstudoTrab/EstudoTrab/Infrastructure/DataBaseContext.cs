using EstudoTrab.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace EstudoTrab.Infrastructure
{
    public class DataBaseContext:DbContext
    {
        public DataBaseContext()
        {
            DropCreateDatabaseIfModelChanges<DataBaseContext> initializer =
     new DropCreateDatabaseIfModelChanges<DataBaseContext>();
             Database.SetInitializer<DataBaseContext>(initializer);
        }

        public DbSet<Cliente> clientes { get; set; }

        public DbSet<Editora> editoras { get; set; }

        public DbSet<Conta> contas { get; set; }

        public DbSet<Livro> livros { get; set; }

        public DbSet<Aluno> alunos { get; set; }


}
}