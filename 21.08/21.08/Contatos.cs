using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._08
{
    internal class Contatos
    {
        private readonly List<Contato> agenda;

        public Contatos()
        {
            agenda = new List<Contato>();
        }

        public bool adicionar(Contato c)
        {
            bool adicionou = false;

            if (agenda.Count == 0)
            {
                agenda.Add(c);
                adicionou = true;
            } else
            {
                foreach (Contato cont in agenda)
                {
                    if (c.Equals(cont))
                    {
                        adicionou = false;
                    }
                    else
                    {
                        agenda.Add(cont);
                        adicionou = true;
                        break;
                    }
                }
            }
            return adicionou;
        }

        public Contato pesquisar(Contato c)
        {
            Contato achado = new Contato();
            foreach (Contato cont in agenda)
            {
                if (c.Equals(cont))
                {
                    achado = cont;
                } else
                {
                    achado = new Contato("---", "---", new Data(0, 0, 0));
                }
            }
            return achado;
        }

        public bool alterar(Contato c)
        {
            bool alterou = false;
            foreach (Contato cont in agenda)
            {
                if (c.Equals(cont))
                {
                    cont.Nome = "Alterado";
                    cont.Email = "---";
                    cont.DtNasc = new Data(0,0,0);
                    alterou = true;
                    break;
                }
            }
            return alterou;
        }

        public bool remover(Contato c)
        {
            bool removeu = false;
            foreach (Contato cont in agenda)
            {
                if (c.Equals(cont))
                {
                    agenda.Remove(cont);
                    removeu = true;
                    break;
                }
            }
            return removeu;
        }

        public override string ToString()
        {
            string s = "";
            foreach (Contato cont in agenda)
            {
                s += cont.ToString() + "\n";
            }
            return s;
        }
    }
}
