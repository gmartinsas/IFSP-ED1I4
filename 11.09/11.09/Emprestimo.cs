using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._09
{
    internal class Emprestimo
    {
        private readonly DateTime dtEmprestimo;
        private DateTime dtDevolucao;

        public Emprestimo()
        {
            dtEmprestimo = DateTime.Now;
        }

        public DateTime DtDevolucao { get => dtDevolucao; set => dtDevolucao = value; }
    }
}
