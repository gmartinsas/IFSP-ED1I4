using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._09
{
    internal class Exemplar
    {
        private int tombo;
        private List<Emprestimo> emprestimos;

        public Exemplar()
        {
            tombo = DateTime.Now.Day * DateTime.Now.Second;
            emprestimos = new List<Emprestimo>();
        }

        public int Tombo { get => tombo; set => tombo = value; }

        public bool emprestar()
        {
            bool emprestou;
            if (this.emprestimos.Last().DtDevolucao == new DateTime(0001, 01, 01, 00, 00, 00))
            {
                emprestou = false;
            } else
            {
                emprestimos.Add(new Emprestimo());
                emprestou = true;
            }
            return emprestou;
        }

        public bool devolver()
        {
            bool devolveu;
            if (this.emprestimos.Last().DtDevolucao == new DateTime(0001, 01, 01, 00, 00, 00))
            {
                this.emprestimos.Last().DtDevolucao = DateTime.Now;
                devolveu = true;
            }
            else
            {
                devolveu = false;
            }
            return devolveu;
        }

        public bool disponivel()
        {
            bool disp;
            if (this.emprestimos.Last().DtDevolucao == new DateTime(0001, 01, 01, 00, 00, 00))
            {
                disp = false;
            }
            else
            {
                disp = true;
            }
            return disp;
        }

        public int qtdeEmprestimos()
        {
            return this.emprestimos.Count;
        }
    }
}
