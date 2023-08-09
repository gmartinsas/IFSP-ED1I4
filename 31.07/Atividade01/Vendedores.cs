using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade01
{
    internal class Vendedores
    {
        private Vendedor[] osVendedores;
        private int max;
        private int qtde;

        public Vendedores(int max, int qtde)
        {
            this.max = max;
            this.qtde = qtde;
            osVendedores = new Vendedor[max];
        }

        public bool addVendedor(Vendedor v)
        {
            if (qtde < max)
            {
                osVendedores[qtde] = v;
                qtde++;
                return true;
            } else { return false; }
        }

        public bool delVendedor(Vendedor v)
        {
            bool deletou = false;
            for (int i = 0; i < osVendedores.Length; i++)
            {
                if (osVendedores[i] != null)
                {
                    if (osVendedores[i].getNome() == v.getNome() && v.getVendas() == 0)
                    {
                        osVendedores[i] = null;
                        deletou = true;
                        break;
                    } else { deletou = false; }
                }
            }
            return deletou;
        }

        public string listarVendedores()
        {
            string n = "Lista de Vendedores: \n";
            for (int i = 0; i < osVendedores.Length; i++)
            {
                if (osVendedores[i] != null)
                {
                    n += osVendedores[i].mostraVendedor() + "\n------\n";
                }
            }
            return n;
        }
        
        public string searchVendedor(Vendedor v)
        {
            string n = "";
            for (int i = 0; i < osVendedores.Length; i++)
            {
                if (osVendedores[i] != null)
                {
                    if (osVendedores[i].getNome() == v.getNome())
                    {
                        n = osVendedores[i].mostraVendedor();
                    } else { n = "Vendedor não encontrado!"; }
                }
            }
            return n;
        }
    }


}
