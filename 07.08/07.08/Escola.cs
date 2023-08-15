using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._08
{
    internal class Escola
    {
        private Curso[] cursos;

        public Escola() => cursos = new Curso[5];

        public bool adicionarCurso(Curso curso)
        {
            int qtdeCursos = 0;
            bool podeAdicionar = false;

            foreach (var c in cursos)
            {
                if (c != null)
                {
                    if (c.getId() == curso.getId()) {
                        qtdeCursos = 15;
                        break;
                    }
                    else { qtdeCursos++; }
                }
            }

            if (qtdeCursos >= 15) { podeAdicionar = false; }
            else
            {                
                for (int i = 0; i < cursos.Length; i++)
                {
                    if (cursos[i] == null)
                    {
                        cursos[i] = curso;
                        podeAdicionar = true;
                        break;
                    }
                }
            }
            return podeAdicionar;
        }

        public bool removerCurso(Curso curso)
        {
            bool podeTirar = false;
            for (int i = 0; i < cursos.Length; i++)
            {
                if (cursos[i] != null && curso.getId() == cursos[i].getId() && curso.qtdeDisciplinas() == 0)
                {
                    cursos[i] = null;
                    podeTirar = true;
                    break;
                }
            }
            return podeTirar;
        }

        public Curso pesquisarCurso(Curso curso)
        {
            for (int i = 0; i < cursos.Length; i++)
            {
                if (cursos[i] != null && curso.getId() == cursos[i].getId())
                {
                    curso = cursos[i];
                    break;
                }
            }
            return curso;
        }
    }
}
