using EstudoTrab.Infrastructure;
using EstudoTrab.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstudoTrab.Test
{
    [TestFixture]
    public class ClienteTest
    {
        [Test]
        public void ClienteSave()
        {
            using (DataBaseContext contex = new DataBaseContext())
            {
                Cliente cliente = new Cliente();
                cliente.Nome = "Paulo Andrada";
                cliente.Idade = 20;
                cliente.CPF =  "110527776744";
                contex.clientes.Add(cliente);
                contex.SaveChanges();
                var cliente2 = contex.clientes.Where(x => x.Nome == "Paulo Andrada").FirstOrDefault();

                Assert.AreEqual(cliente.CPF, cliente2.CPF);
                Assert.AreEqual(cliente.Idade, cliente2.Idade);
             
            }
        }
    }
}