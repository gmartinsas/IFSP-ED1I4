using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opc;
            Console.WriteLine("Projeto Acesso v1.0\n-----");
            Console.WriteLine("Opções:");
            Console.WriteLine(" 0. Sair \n 1. Cadastrar ambiente \n 2. Consultar ambiente");
            Console.WriteLine(" 3. Excluir ambiente \n 4. Cadastrar usuário \n 5. Consultar usuário");
            Console.WriteLine(" 6. Excluir usuário \n 7. Conceder permissão de acesso ao usuário \n 8. Revogar permissão de acesso ao usuário");
            Console.WriteLine(" 9. Registrar acesso \n 10. Consultar logs de acesso");

            Cadastro c = new Cadastro();
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
                            Ambiente a_cad = new Ambiente("Recepção Social");
                            c.adicionarAmbiente(a_cad);
                            break;
                        }
                    case 2:
                        {
                            Ambiente a_pes1 = new Ambiente("TI");
                            Ambiente a_pes2 = new Ambiente("Serviço Social");
                            c.adicionarAmbiente(a_pes1);

                            Console.WriteLine(c.pesquisarAmbiente(a_pes1).ToString());
                            Console.WriteLine(c.pesquisarAmbiente(a_pes2).ToString());
                            break;
                        }
                    case 3:
                        {
                            Ambiente a_rem = new Ambiente("Jurídico");
                            c.adicionarAmbiente(a_rem);

                            Console.WriteLine(c.ToString());
                            Console.WriteLine(c.removerAmbiente(a_rem)?"Removeu.":"Não removeu.");
                            Console.WriteLine(c.ToString());
                            break;
                        }
                    case 4:
                        {
                            Usuario u_cad = new Usuario("Ariel");
                            c.adicionarUsuario(u_cad);

                            Console.WriteLine(c.ToString());
                            break;
                        }
                    case 5:
                        {
                            Usuario u_pes1 = new Usuario("Ariel");
                            Usuario u_pes2 = new Usuario("Rafael");
                            Usuario u_pes3 = new Usuario("Daniel");
                            u_pes1.concederPermissao(new Ambiente("Almoxarife"));

                            c.adicionarUsuario(u_pes1);
                            c.adicionarUsuario(u_pes2);

                            Console.WriteLine(c.pesquisarUsuario(u_pes1).ToString());
                            Console.WriteLine(c.pesquisarUsuario(u_pes2).ToString());
                            Console.WriteLine(c.pesquisarUsuario(u_pes3).ToString());
                            break;
                        }
                    case 6:
                        {
                            Usuario u_rem1 = new Usuario("Ariel");
                            Usuario u_rem2 = new Usuario("Rafael");
                            u_rem1.concederPermissao(new Ambiente("Almoxarife"));

                            c.adicionarUsuario(u_rem1);
                            c.adicionarUsuario(u_rem2);

                            Console.WriteLine(c.removerUsuario(u_rem1)?"Removeu.":"Não removeu");
                            Console.WriteLine(c.removerUsuario(u_rem2)?"Removeu.":"Não removeu");
                            break;
                        }
                    case 7:
                        {
                            Ambiente a_con = new Ambiente("Seg. Patrimonial");
                            Usuario u_con = new Usuario("Fábio");

                            u_con.concederPermissao(a_con);
                            Console.WriteLine(u_con.ToString());
                            break;
                        }
                    case 8:
                        {
                            Ambiente a_rev = new Ambiente("Seg. Patrimonial");
                            Usuario u_rev = new Usuario("Fábio");
                            u_rev.concederPermissao(a_rev);
                            Console.WriteLine(u_rev.ToString());

                            Console.WriteLine(u_rev.revogarPermissao(a_rev)?"Removeu.":"Não removeu.");
                            Console.WriteLine(u_rev.ToString());
                            break;
                        }
                    case 9:
                        {
                            Ambiente a_ace = new Ambiente("RH");
                            Usuario u_ace = new Usuario("Ariel");
                            Log l1 = new Log(u_ace, true);

                            a_ace.registrarLog(l1);
                            Console.WriteLine(a_ace.ToString());
                            break;
                        }
                    case 10:
                        {
                            Ambiente a_logs = new Ambiente("RH");
                            Usuario u_logs = new Usuario("Ariel");
                            Log l1 = new Log(u_logs, true);
                            Log l2 = new Log(u_logs, false);

                            a_logs.registrarLog(l1);
                            a_logs.registrarLog(l2);
                            Console.WriteLine(a_logs.ToString());
                            break;
                        }
                }
            } while (opc != 0);
        }
    }
}
