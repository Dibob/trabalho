using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Teste
    {
        static void Main(string[] args)
        {


            Funcionario func = new Funcionario();
            func.Nome = "diego";
            func.Salario = 12232.3;

            Conta conta = new Conta();

            conta.Limite = 5.000;
            conta.Numero = 12;
            conta.Saldo = 2.300;


            Console.WriteLine(conta.Limite);
            Console.WriteLine(conta.Numero);
            Console.WriteLine(conta.Saldo);
        }
    }
}
