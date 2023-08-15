using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._08
{
    internal class Curso
    {
        private int id;
        private string descricao;
        private Disciplina[] disciplinas;

        public Curso(int id, string descricao)
        {
            this.id = id;
            this.descricao = descricao;
            this.disciplinas = new Disciplina[12];
        }

        public int getId() { return id; }
        public string getDescricao() {  return descricao; }

        public bool adicionarDisciplina(Disciplina disciplina)
        {
            int materias = 0;
            bool limiteMaterias = false;
            
            foreach (var d in disciplinas)
            {
                if (d != null)
                {
                    if (d.getId() == disciplina.getId())
                    {
                        materias = 12;
                        break;
                    } else { materias++; }
                }
            }

            if (materias >= 12) { limiteMaterias = false; }
            else
            {
                for (int i = 0; i < disciplinas.Length; i++)
                {
                    if (disciplinas[i] == null )
                    {
                        disciplinas[i] = disciplina;
                        limiteMaterias = true;
                        break;
                    }
                }
            }
            return limiteMaterias;
        }

        public Disciplina pesquisarDisciplina(Disciplina disciplina)
        {
            for (int i = 0; i < disciplinas.Length; i++)
            {
                if (disciplinas[i] != null && disciplina.getId() == disciplinas[i].getId())
                {
                    disciplina = disciplinas[i];
                    break;
                }
            }
            return disciplina;
        }

        public bool removerDisciplina(Disciplina disciplina)
        {
            bool podeTirar = false;
            for (int i = 0; i < disciplinas.Length; i++)
            {
                if (disciplinas[i] != null && disciplina.getId() == disciplinas[i].getId() && disciplinas[i].qtdeAlunos() == 0)
                {
                    disciplinas[i] = null;
                    podeTirar = true;
                    break; 
                } else { podeTirar = false; }
            }
            return podeTirar;
        }

        public string listaDisciplinas()
        {
            string n = "";

            foreach (var d in disciplinas)
            {
                if (d != null)
                {
                    n += d.getDescricao() + "\n";
                }
            }
            return n;
        }

        public int qtdeDisciplinas()
        {
            int qtde = 0;
            for (int i = 0; i < disciplinas.Length; i++)
            {
                if (disciplinas[i] != null)
                {
                    qtde++;
                }
            }
            return qtde;
        }
    }
}
