using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Emprestimo : Servico
    {
        public  override void CalculaTaxa()
        {

        }


        public override double CalculaValorNominal()
        {
            return base.CalculaValorNominal()*10;
        }
    }
}
