using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap14
{
    class String
    {
        static void Main(string[] args)
        {
            string nome = "diego";
            string nome2 = "Diego";
            string trim = "     Lobster boco as";
            string split = "vamos,ate";
            string replace = "abacaxi e pera";
            Console.WriteLine(nome.ToUpper());
            Console.WriteLine(nome2.ToLower());
            Console.WriteLine(trim);
            Console.WriteLine(trim.Trim());
            foreach (string item in split.Split(','))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(replace.Replace("abacaxi","manga"));
        }
    }
}
