using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._10
{
    internal class Cadastro
    {
        private List<Usuario> usuarios;
        private List<Ambiente> ambientes;

        public Cadastro()
        {
            usuarios = new List<Usuario>();
            ambientes = new List<Ambiente>();
        }

        public void adicionarUsuario(Usuario usuario)
        {
            usuarios.Add(usuario);
        }

        public bool removerUsuario(Usuario usuario)
        {
            bool removeu;

            if (usuario.Ambientes.Count == 0)
            {
                removeu = true;
                usuarios.Remove(usuario);
            } else
            {
                removeu = false;
            }

            return removeu;
        }

        public Usuario pesquisarUsuario(Usuario usuario)
        {
            Usuario uAchado = new Usuario("---");
            
            foreach (Usuario u in usuarios)
            {
                if (u.Nome == usuario.Nome)
                {
                    uAchado = u;
                    break;
                }
            }
            return uAchado;
        }

        public void adicionarAmbiente(Ambiente ambiente)
        {
            ambientes.Add(ambiente);
        }

        public bool removerAmbiente(Ambiente ambiente)
        {
            bool removeu = false;
            foreach(Ambiente a in ambientes)
            {
                if (ambiente.Nome == a.Nome)
                {
                    ambientes.Remove(a);
                    removeu = true;
                    break;
                }
            }
            return removeu;
        }

        public Ambiente pesquisarAmbiente(Ambiente ambiente)
        {
            Ambiente aAchado = new Ambiente("---");

            foreach (Ambiente a in ambientes)
            {
                if (a.Nome == ambiente.Nome)
                {
                    aAchado = a;
                    break;
                }
            }
            return aAchado;
        }

        public override string ToString()
        {
            string str = "";

            str += "Ambientes:\n";
            
            foreach (Ambiente a in ambientes)
            {
                str += a.Nome + "\n";
            }

            str += "\nUsuários:\n";

            foreach (Usuario u in usuarios)
            {
                str += u.Nome + "\n";
            }

            return str;
        }

        public void upload()
        {
            Console.WriteLine("Up!");
        }

        public void download()
        {
            Console.WriteLine("Down!");
        }
    }
}
