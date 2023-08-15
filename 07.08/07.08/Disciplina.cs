using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._08
{
    internal class Disciplina
    {
        private int id;
        private string descricao;
        private Aluno[] alunos;

        public int getId() { return id; }
        public string getDescricao() { return descricao; }

        public Disciplina(int id, string descricao)
        {
            this.id = id;
            this.descricao = descricao;
            this.alunos = new Aluno[15];
        }

        public bool matricularAluno(Aluno aluno)
        {
            int matriculados = 0;
            bool turmaCheia = false;

            foreach (var a in alunos)
            {
                if (a != null)
                {
                    if (a.getId() == aluno.getId())
                    {
                        matriculados = 15;
                        break;
                    } else
                    {
                        matriculados++;
                    }
                }
            }

            if (matriculados >= 15) { turmaCheia = false; } 
            else
            {                
                for (int i = 0; i < alunos.Length; i++)
                {
                    if (alunos[i] == null)
                    {
                        alunos[i] = aluno;
                        turmaCheia = true;
                        break;
                    }
                }
            }
            return turmaCheia;
        }

        public bool desmatricularAluno(Aluno aluno)
        {
            bool podeTirar = false;
            for (int i = 0; i < alunos.Length; i++)
            {
                if (alunos[i] != null && aluno.getId() == alunos[i].getId())
                {
                    alunos[i] = null;
                    podeTirar = true;
                    break;
                }
            }
            return podeTirar;
        }

        public int qtdeAlunos()
        {
            int qtde = 0;
            for (int i = 0; i < alunos.Length; i++)
            {
                if (alunos[i] != null)
                {
                    qtde++;
                }
            }
            return qtde;
        }

        public string listaAlunos()
        {
            string n = "";
            
            foreach (var a in alunos)
            {
                if (a != null)
                {
                    n += a.getNome() + "\n";
                }
            }
            return n;
        }
    }
}
