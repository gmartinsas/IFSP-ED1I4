using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._10
{
    internal class Usuario
    {
        private int id;
        private string nome;
        private List<Ambiente> ambientes;

        public Usuario(string n)
        {
            id = DateTime.Now.Day * DateTime.Now.Second;
            Nome = n;
            ambientes = new List<Ambiente>();
        }

        public string Nome { get => nome; set => nome = value; }
        internal List<Ambiente> Ambientes { get => ambientes; set => ambientes = value; }

        public bool concederPermissao(Ambiente ambiente)
        {
            bool concedeu = true;

            foreach (var a in Ambientes)
            {
                if (a.Nome == ambiente.Nome)
                {
                    concedeu = false;
                    break;
                }
            }

            if (concedeu)
            {
                Ambientes.Add(ambiente);
            }

            return concedeu;
        }

        public bool revogarPermissao(Ambiente ambiente)
        {
            bool revogou = false;

            foreach (var a in Ambientes)
            {
                if (a.Nome == ambiente.Nome)
                {
                    Ambientes.Remove(a);
                    revogou = true;
                    break;
                }
            }

            return revogou;
        }

        public string listaAmbientes()
        {
            string str = "";
            
            foreach (var a in Ambientes)
            {
                str += a.Nome + "\n";
            }

            return str;
        }

        public override string ToString()
        {
            return Nome + "\n" + listaAmbientes();
        }
    }
}
