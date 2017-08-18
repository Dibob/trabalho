using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinamentoC
{
    class Exercicio3OrdenandoUm_Arraycs
    {
        static void Main(string[] args)
        {
            System.Array.Sort(args);

            foreach (var item in args)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
