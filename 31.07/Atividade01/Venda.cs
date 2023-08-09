using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade01
{
    internal class Venda
    {
        private int qtde;
        private double valor;

        public Venda(int qtde, double valor)
        {
            this.qtde = qtde;
            this.valor = valor;
        }

        public double valorMedio()
        {
            return valor / qtde;
        }

        /* Escopo para métodos extras necessários */

        public double getValor()
        {
            return valor;
        }
    }
}
