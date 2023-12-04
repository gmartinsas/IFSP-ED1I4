using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._11
{
    internal class Garagem
    {
        private int id;
        private string nome;
        private Queue<Van> lotacao;

        public Garagem(string nome)
        {
            this.id = DateTime.Now.Second * DateTime.Now.Millisecond;
            this.nome = nome;
            this.lotacao = new Queue<Van>();
        }

        public string Nome {  get { return nome; } }
        public void adicionarVan(Van v)
        {
            lotacao.Enqueue(v);
        }
        public void removerVan()
        {
            foreach (Van v in lotacao)
            {
                lotacao.Dequeue();
            }
        }

        public string listaVans()
        {
            string n = "";
            foreach (var v in lotacao)
            {
                n += v.ToString() + "\n";
            }
            return n;
        }
    }
}
