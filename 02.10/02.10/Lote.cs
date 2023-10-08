using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _02._10
{
    internal class Lote
    {
        private int id;
        private int qtde;
        private DateTime venc;

        public Lote(int i, int q, DateTime d)
        {
            this.id = i;
            this.qtde = q;
            this.venc = d;
        }

        public int Id { get => id; set => value = id; }
        public int Qtde { get => qtde; set => qtde = value; }
        public DateTime Venc { get => venc; set => venc = value; }

        public override string ToString()
        {
            return Id.ToString() + "-" + Qtde.ToString() + "-" + Venc.ToString();
        }
    }
}
