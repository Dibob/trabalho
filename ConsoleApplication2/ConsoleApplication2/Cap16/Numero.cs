using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.Cap16
{
    class Numero
    {

        delegate bool Filtro(int numero);


        static void Main(string[] args)
        {
            int[] numeros = { 1, 2, 3, 4, 5, 6 };

            Filtro filtroPar = Numero.FiltraPar;
            Numero obj = new Numero();

            Filtro filtroImpar = obj.FiltraImpar;

            Console.WriteLine("numeros pares:");

            Numero.ImprimeNumeros(numeros, filtroPar);


            Console.WriteLine("numeros impares");

            Numero.ImprimeNumeros(numeros, filtroImpar);

        }

        static bool FiltraPar(int numero)
        {
            return numero % 2 == 0;
        }


        bool FiltraImpar(int numero)
        {
            return numero % 2 == 1;
        }

        static void ImprimeNumeros(int[] numeros, Filtro filtro)
        {
            foreach (var numero in numeros)
            {
                if (filtro(numero))
                {
                    Console.Write("{0} ", numero);
                }
            }
            Console.WriteLine();
        }
    }
}
