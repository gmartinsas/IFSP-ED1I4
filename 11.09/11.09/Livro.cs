using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._09
{
    internal class Livro
    {
        private int isbn;
        private string titulo;
        private string autor;
        private string editora;
        private List<Exemplar> exemplares;

        public Livro(string t, string a, string e)
        {
            this.isbn = DateTime.Now.Day * DateTime.Now.Second;
            this.titulo = t;
            this.autor = a;
            this.editora = e;
            this.exemplares = new List<Exemplar>();
        }

        public List<Exemplar> Exemplares { get => exemplares; set => exemplares = value; }
        public int Isbn { get => isbn; set => isbn = value; }

        public void adicionarExemplar(Exemplar exemplar)
        {
            exemplares.Add(exemplar);
        }

        public int qtdeExemplares()
        {
            return exemplares.Count;
        }

        public int qtdeDisponiveis()
        {
            int q = 0;
            foreach (var item in exemplares)
            {
                if (item.disponivel())
                {
                    q++;
                }
            }
            return q;
        }

        public int qtdeEmprestimos()
        {
            int q = 0;
            foreach (var item in exemplares)
            {
                q += item.qtdeEmprestimos();
            }
            return q;
        }

        public double percDisponibilidade()
        {
            int v = 0;
            foreach (var item in exemplares)
            {
                if (item.disponivel())
                {
                    v++;
                }
            }
            return ((v / exemplares.Count) * 100);
        }

        public override string ToString()
        {
            string s = "ISBN: " + isbn + "\n"
            + "Título: " + titulo + "\n"
            + "Autor: " + autor + "\n"
            + "Editora: " + editora + "\n";
            
            return s;
        }
    }
}
