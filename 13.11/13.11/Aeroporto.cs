using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _13._11
{
    internal class Aeroporto
    {
        private List<Garagem> garagens;
        private string nome;

        public string Nome { get => this.nome; }

        public Aeroporto(string n)
        {
            this.nome = n;
            this.garagens = new List<Garagem>();
        }

        public void adicionarGaragem(Garagem g)
        {
            garagens.Add(g);
        }
        
        public void lotarGaragem(Frota f)
        {
            for (int i = 0; i < garagens.Count; i++)
            {
                for (int j = 0; i < f.Vans.Count; j++)
                {
                    garagens.ElementAt(i).adicionarVan(f.Vans.ElementAt(j));
                }
            }
        }

        public void esvaziarGaragem()
        {
            for (int i = 0; i < garagens.Count; i++)
            {
                garagens.ElementAt(i).removerVan();
            }
        }
    }
}
