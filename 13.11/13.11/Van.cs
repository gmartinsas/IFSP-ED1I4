using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _13._11
{
    internal class Van
    {
        private int id;
        private int lotacao;
        private bool cheia;

        public Van(int id, int lotacao)
        {
            this.id = id;
            this.lotacao = lotacao;
            this.cheia = false;
        }

        public bool Cheia { get => cheia; set => _ = this.cheia; }
        public int Lotacao { get => lotacao; }
        public int Id { get => id; set => _ = this.id; }

        public override string ToString()
        {
            return "Van " + id.ToString() + " - Lotação: " + lotacao.ToString();
        }
    }
}
