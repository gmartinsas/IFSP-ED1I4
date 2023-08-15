using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._08
{
    internal class Aluno
    {
        private int id;
        private string nome;

        public Aluno(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }
        public int getId() { return id; }
        public string getNome() {  return nome; }

        /*
        public bool podeMatricular(Curso curso)
        {
            // Adicionar o método de busca com os parâmetros sendo os atributos da classe.
        }
        */
    }
}
