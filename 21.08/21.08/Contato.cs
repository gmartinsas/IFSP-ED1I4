using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _21._08
{
    internal class Contato
    {
        private string email;
        private string nome;
        private Data dtnasc;
        private List<Telefone> telefones;

        public Contato(string email, string nome, Data dtnasc)
        {
            this.email = email;
            this.nome = nome;
            this.dtnasc = dtnasc;
            this.telefones = new List<Telefone>();
        }

        public Contato(): this("", "", new Data(0, 0, 0)) { }

        public string Email { get => email; set => email = nome; }
        public string Nome { get => nome; set => nome = value; }
        public Data DtNasc { get => dtnasc; set => dtnasc = value; }

        public int getIdade()
        {
            return 2023 - dtnasc.Ano;
        }

        public void adicionarTelefone(Telefone t)
        {
            if (telefones.Count == 0)
            {
                this.telefones.Add(t);
                t.Principal = true;
            } else { this.telefones.Add(t); }
        }

        public string getTelefonePrincipal()
        {
            string p = "";
            
            foreach (Telefone t in telefones)
            {
                if (t.Principal == true)
                {
                    p = t.Numero;
                    break;
                }
            }

            return p;
        }

        public override string ToString()
        {
            return nome + "\n" + email + "\n" + dtnasc.ToString() + "\n" + this.getTelefonePrincipal();
        }

        public override bool Equals(object obj)
        {
            return this.getTelefonePrincipal().Equals(((Contato)obj).getTelefonePrincipal());
        }
    }
}
