using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._09
{
    internal class Livros
    {
        private List<Livro> livros;

        public Livros()
        {
            this.livros = new List<Livro>();
        }

        public void adicionar(Livro livro)
        {
            livros.Add(livro);
        }

        public Livro pesquisar(Livro livro)
        {
            Livro l = new Livro("-", "-", "-");
            foreach (var item in livros)
            {
                if (livro.Isbn == item.Isbn)
                {
                    l = item;
                    break;
                }
            }
            return l;
        }
    }
}
