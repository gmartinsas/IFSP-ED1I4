using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _21._08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opc;
            Console.WriteLine("Minha Agenda v1.0\n-----");
            Console.WriteLine("Opções:");
            Console.WriteLine(" 0. Sair \n 1. Adicionar Contato \n 2. Adicionar Telefone no Contato");
            Console.WriteLine(" 3. Pesquisar Contato \n 4. Alterar Contato \n 5. Remover Contato");
            Console.WriteLine(" 6. Listar Contatos");

            Contatos listaN1 = new Contatos();
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
                            Data dtAriel = new Data(8, 3, 2002);
                            Contato a1 = new Contato("ariel@ifsp.edu.br", "Ariel", dtAriel);
                            listaN1.adicionar(a1);
                            break;
                        }
                    case 2:
                        {
                            Data dtAriel = new Data(8, 3, 2002);
                            listaN1.pesquisar(new Contato("ariel@ifsp.edu.br", "Ariel", dtAriel)).adicionarTelefone(new Telefone("Celular", "978203149"));
                            break;
                        }
                    case 3:
                        {
                            Data dtAriel = new Data(8, 3, 2002);
                            Console.WriteLine(listaN1.pesquisar(new Contato("ariel@ifsp.edu.br", "Ariel", dtAriel)).ToString());
                            break;
                        }
                    case 4:
                        {
                            Data dtAriel = new Data(8, 3, 2002);
                            Console.WriteLine(listaN1.alterar(new Contato("ariel@ifsp.edu.br", "Ariel", dtAriel)) ? "Alterou" : "Não alterou");
                            break;
                        }
                    case 5:
                        {
                            Data dtAriel = new Data(8, 3, 2002);
                            Console.WriteLine(listaN1.remover(new Contato("ariel@ifsp.edu.br", "Ariel", dtAriel)) ? "Removeu" : "Não removeu");
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine(listaN1.ToString());
                            break;
                        }
                }
            } while (opc != 0);
        }
    }
}
