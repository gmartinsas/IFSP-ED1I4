using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opc;
            Console.WriteLine("Minha Livraria v1.0\n-----");
            Console.WriteLine("Opções:");
            Console.WriteLine(" 0. Sair \n 1. Adicionar Livro \n 2. Pesquisar Livro (sintético)");
            Console.WriteLine(" 3. Pesquisar Livro (analítico) \n 4. Adicionar Exemplar \n 5. Registrar Empréstimo");
            Console.WriteLine(" 6. Registrar Empréstimo");

            Livros livros = new Livros();
            do
            {
                Console.WriteLine("------");
                Console.Write("Opção escolhida: ");
                opc = Int32.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 0: break;
                    case 1:
                        {
                            Livro l_add = new Livro("Traços", "Eduardo Cilto", "Outro Planeta");
                            l_add.Isbn = 1;
                            livros.adicionar(l_add);
                            break;
                        }
                    case 2:
                        {
                            Livro l_pesqS = new Livro("Submerso", "Eduardo Cilto", "Outro Planeta");
                            Console.WriteLine(livros.pesquisar(l_pesqS).ToString());

                            l_pesqS.Isbn = 1;
                            Console.WriteLine(livros.pesquisar(l_pesqS).ToString());
                            break;
                        }
                    case 3:
                        {
                            Livro l_pesqA = new Livro("Submerso", "Eduardo Cilto", "Outro Planeta");
                            Console.WriteLine(livros.pesquisar(l_pesqA).ToString());
                            break;
                        }
                    case 4:
                        {
                            Livro l_exe = new Livro("Bíblia", "Uma galera", "Faz tempo");
                            Exemplar ex1 = new Exemplar();
                            l_exe.adicionarExemplar(ex1);
                            break;
                        }
                    case 5:
                        {
                            Livro l_emp = new Livro("Ficando", "Sem", "Ideias");
                            Exemplar exPadrao = new Exemplar();
                            l_emp.adicionarExemplar(exPadrao);
                            Console.WriteLine(exPadrao.emprestar()?"Emprestou":"Não emprestou");
                            break;
                        }
                    case 6:
                        {
                            Livro l_dev = new Livro("Ficando", "Sem", "Ideias");
                            Exemplar exPadrao2 = new Exemplar();
                            l_dev.adicionarExemplar(exPadrao2);
                            Console.WriteLine(exPadrao2.emprestar() ? "Emprestou" : "Não emprestou");
                            Console.WriteLine(exPadrao2.devolver() ? "Devolveu" : "Já foi devolvido");
                            break;
                        }
                }
            } while (opc != 0);
        }
    }
}
