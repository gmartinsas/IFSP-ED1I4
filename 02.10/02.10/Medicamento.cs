using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _02._10
{
    internal class Medicamento
    {
        private int id;
        private string nome;
        public string laboratorio;
        public Queue<Lote> lotes;

        public Medicamento(int id, string nome, string laboratorio, Queue<Lote> lotes)
        {
            this.id = id;
            this.nome = nome;
            this.laboratorio = laboratorio;
            this.lotes = lotes;
        }

        public Medicamento() : this(0, "", "",  null) { }

        public int Id { get => id; set => id = value; } 
        public string Nome { get => nome; set => nome = value; }
        public string Laboratorio { get => laboratorio; set => laboratorio = value; }
        public Queue<Lote> Lotes { get => lotes; set => lotes = value; }

        public int qtdeDisponivel()
        {
            int q = 0;
            foreach (Lote lote in lotes)
            {
                q += lote.Qtde;
            }
            return q;
        }
        
        public void comprar(Lote lote)
        {
            lotes.Enqueue(lote);
        }

        public bool vender(int qtde)
        {
            bool vendeu = false;
            if (lotes != null)
            {
                if (lotes.Peek().Qtde >= qtde)
                {
                    lotes.Dequeue();
                    vendeu = true;
                } else if (lotes.Count() > 1)
                {
                    int resto = lotes.Peek().Qtde;
                    lotes.Dequeue();
                    lotes.Peek().Qtde =- resto;
                    vendeu = true;
                } else
                {
                    vendeu = false;
                }
            }
            return vendeu;
        }

        public override string ToString()
        {
            return Id.ToString() + "-" + Nome + "-" + Laboratorio + "-" + qtdeDisponivel();
        }

        public override bool Equals(object obj)
        {
            return this.Id.Equals(((Lote)obj).Id);
        }
    }
}
