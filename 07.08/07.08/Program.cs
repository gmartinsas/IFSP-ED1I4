using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opc;
            Console.WriteLine("SUAP --- IFSP v2.0\n-----");
            Console.WriteLine("Opções:");
            Console.WriteLine(" 0. Sair \n 1. Adicionar curso \n 2. Pesquisar curso \n 3. Remover curso");
            Console.WriteLine(" 4. Adicionar disciplina no curso \n 5. Pesquisar disciplina \n 6. Remover disciplina do curso");
            Console.WriteLine(" 7. Matricular aluno na disciplina \n 8. Remover aluno da disciplina \n 9. Pesquisar aluno");

            do
            {
                Console.WriteLine("------");
                Console.Write("Opção escolhida: ");
                opc = Int32.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 0: { break; }
                    case 1:
                        {
                            Escola ifsp = new Escola();
                            Curso ads5 = new Curso(1000, "O melhor curso do IFSP CBT!");

                            Console.WriteLine(ifsp.adicionarCurso(ads5) ? "Adicionou" : "Não adicionou");
                            Console.WriteLine(ifsp.adicionarCurso(ads5) ? "Adicionou" : "Não adicionou");
                            break;
                        }
                    case 2:
                        {
                            Escola fatec = new Escola();
                            Curso ti = new Curso(-2, "TI");
                            Disciplina j1 = new Disciplina(1, "Java");
                            Disciplina j2 = new Disciplina(2, "Java II");
                            fatec.adicionarCurso(ti);
                            ti.adicionarDisciplina(j1);
                            ti.adicionarDisciplina(j2);

                            if (fatec.pesquisarCurso(ti) != null)
                            {
                                Console.WriteLine(fatec.pesquisarCurso(ti).getDescricao());
                                Console.WriteLine(fatec.pesquisarCurso(ti).listaDisciplinas());
                            } else { Console.WriteLine("Não achou."); }
                            break;
                        }
                    case 3:
                        {
                            Escola ifspcbt = new Escola();
                            Curso tur = new Curso(12, "Turismo");
                            Curso let = new Curso(13, "Letras");
                            Disciplina geo = new Disciplina(66, "Geografia");
                            ifspcbt.adicionarCurso(let);
                            ifspcbt.adicionarCurso(tur);
                            let.adicionarDisciplina(geo);

                            Console.WriteLine(ifspcbt.removerCurso(tur) ? "Removeu" : "Não removeu");
                            Console.WriteLine(ifspcbt.removerCurso(let) ? "Removeu" : "Não removeu");
                            break;
                        }
                    case 4:
                        {
                            Curso csa = new Curso(0, "Aut1");
                            Disciplina adm = new Disciplina(1413, "Introdução a Administração");

                            Console.WriteLine(csa.adicionarDisciplina(adm) ? "Adicionou" : "Não adicionou");
                            Console.WriteLine(csa.adicionarDisciplina(adm) ? "Adicionou" : "Não adicionou");
                            break;
                        }
                    case 5:
                        {
                            Curso e3 = new Curso(3, "Exemplo 3");
                            Disciplina ed1 = new Disciplina(541, "Estrutura de Dados I");
                            Aluno m1 = new Aluno(1, "Marco");
                            e3.adicionarDisciplina(ed1);
                            ed1.matricularAluno(m1);

                            if (e3.pesquisarDisciplina(ed1) != null)
                            {
                                Console.WriteLine(e3.pesquisarDisciplina(ed1).getDescricao());
                                Console.WriteLine(e3.pesquisarDisciplina(ed1).listaAlunos());
                            }
                            else { Console.WriteLine("Não encontrou");  }
                            break;
                        }
                    case 6:
                        {
                            Curso e2 = new Curso(2, "Exemplo 2");
                            Disciplina ing1 = new Disciplina(91471, "Inglês Técnico Básico");
                            Disciplina ing2 = new Disciplina(91472, "Inglês Técnico Avançado");
                            Aluno d1 = new Aluno(0, "Daniela");
                            e2.adicionarDisciplina(ing1);
                            e2.adicionarDisciplina(ing2);
                            ing2.matricularAluno(d1);

                            Console.WriteLine(e2.removerDisciplina(ing1) ? "Removeu" : "Não removeu.");
                            Console.WriteLine(e2.removerDisciplina(ing2) ? "Removeu" : "Não removeu.");
                            break;
                        }
                    case 7:
                        {
                            Disciplina matf = new Disciplina(12120, "Matemática Financeira");
                            Aluno a1 = new Aluno(3021521, "Ariel");
                            Console.WriteLine(matf.matricularAluno(a1) ? "Matriculou" : "Falha na matrícula.");
                            Console.WriteLine(matf.matricularAluno(a1) ? "Matriculou" : "Falha na matrícula.");
                            break;
                        }
                    case 8:
                        {
                            Disciplina est = new Disciplina(51920, "Estatística");
                            Aluno e1 = new Aluno(1, "Enzo");
                            Console.WriteLine(est.matricularAluno(e1) ? "Matriculou" : "Falha na matrícula.");
                            Console.WriteLine(est.desmatricularAluno(e1) ? "Desmatriculou" : "Falha na desmatricula.");
                            break;
                        }
                    case 9:
                        {
                            break;
                        }
                }
            } while (opc != 0);
        }
    }
}
