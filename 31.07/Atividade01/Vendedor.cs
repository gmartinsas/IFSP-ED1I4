using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade01
{
    internal class Vendedor
    {
        private int id;
        private string nome;
        private double percComissao;
        private Venda[] asVendas;

        public Vendedor(int id, string nome, double percComissao)
        {
            this.id = id;
            this.nome = nome;
            this.percComissao = percComissao / 100;
            this.asVendas = new Venda[31];
        }

        public void registrarVenda(int dia, Venda venda)
        {
            asVendas[dia] = venda;
        }

        public double valorVendas()
        {
            double totalVendas = 0;
            for (int i = 0; i < asVendas.Length; i++)
            {
                if (asVendas[i] != null)
                {
                    totalVendas += asVendas[i].getValor();
                }
            }
            return totalVendas;
        }

        public double valorComissao()
        {
            double totalComissao = 0;
            for (int i = 0; i < asVendas.Length; i++)
            {
                if (asVendas[i] != null)
                {
                    totalComissao = asVendas[i].getValor() + (asVendas[i].getValor() * percComissao);
                }
            }
            return totalComissao;
        }

        /* Escopo para métodos extras necessários */

        /*
        public void teste()
        {
            for (int i = 0; i < this.asVendas.Length; i++) { Console.WriteLine(asVendas[i] + "-"); }
        }
        */

        public string getNome()
        {
            return nome;
        }

        public int getVendas()
        {
            int totalNVendas = 0;
            for (int i = 0; i < asVendas.Length; i++)
            {
                if (asVendas[i] != null)
                {
                    totalNVendas++;
                }
            }
            return totalNVendas;
        }

        public string mostraVendedor()
        {
            string n = "";
            n = "Id: " + id + "\nNome: " + nome;
            n += "\nValor Total das Vendas: " + valorVendas();
            n += "\nValor Total das Comissoes: " + valorComissao();
            n += "\nNúmero de vendas: " + getVendas();
            return n;
        }

    }
}
