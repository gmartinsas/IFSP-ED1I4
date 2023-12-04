using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _13._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opc;
            Console.WriteLine("Logística -- Empresa v1.0\n-----");
            Console.WriteLine("Opções:");
            Console.WriteLine(" 0. Sair \n 1. Cadastrar veículo \n 2. Cadastrar garagem");
            Console.WriteLine(" 3. Iniciar jornada \n 4. Terminar jornada \n 5. Liberar viagem de uma determinada origem para um determinado destino");
            Console.WriteLine(" 6. Listar veículos em determinada garagem \n 7. Informar quantidade de viagens de uma determinada origem para um determinado destino");
            Console.WriteLine(" 8. Listar viagens de uma determinada origem para um determinado destino");

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
                            Van v_cad = new Van(1, 50);
                            break;
                        }
                    case 2:
                        {
                            Garagem g_cad = new Garagem("G1");
                            break;
                        }
                    case 3:
                        {
                            Aeroporto vc_cad = new Aeroporto("Vira-Copos");
                            Aeroporto gru_cad = new Aeroporto("Guarulhos");
                            Frota f_cad = new Frota(1);
                            f_cad.adicionarVan(new Van(1, 0));
                            Viagem v_ini = new Viagem(vc_cad, gru_cad, f_cad);
                            v_ini.iniciarViagem();
                            break;
                        }
                    case 4:
                        {
                            Aeroporto vc_cad = new Aeroporto("Vira-Copos");
                            Aeroporto gru_cad = new Aeroporto("Guarulhos");
                            Frota f_cad = new Frota(1);
                            f_cad.adicionarVan(new Van(1, 50));
                            Viagem v_ini = new Viagem(vc_cad, gru_cad, f_cad);
                            break;
                        }
                    case 5:
                        {
                            Aeroporto vc_cad = new Aeroporto("Vira-Copos");
                            Aeroporto gru_cad = new Aeroporto("Guarulhos");
                            Frota f_cad = new Frota(1);
                            f_cad.adicionarVan(new Van(1, 50));
                            Viagem v_ini = new Viagem(vc_cad, gru_cad, f_cad);
                            v_ini.iniciarViagem();
                            break;
                        }
                    case 6:
                        {
                            Garagem g_lis = new Garagem("G1");
                            g_lis.adicionarVan(new Van(200, 300));
                            Console.WriteLine(g_lis.listaVans());
                            break;
                        }
                    case 7:
                        {
                            Frota f4 = new Frota(10);
                            Console.WriteLine(f4.Viagens);
                            break;
                        }
                    case 8:
                        {
                            Frota f4 = new Frota(10);
                            Console.WriteLine(f4.Viagens);
                            break;
                        }
                    case 9:
                        {
                            Frota f5 = new Frota(15);
                            Console.WriteLine(f5.mostraCapacidade());
                            break;
                        }
                }
            } while (opc != 0);
        }
    }
}
