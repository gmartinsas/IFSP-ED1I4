using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace _02._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opc;
            Console.WriteLine("FarmaIFSP v1.0\n-----");
            Console.WriteLine("Opções:");
            Console.WriteLine(" 0. Finalizar processo \n 1. Cadastrar medicamento \n 2. Consultar medicamento");
            Console.WriteLine(" 3. Consultar medicamento \n 4. Comprar medicamento \n 5. Vender Medicamento");
            Console.WriteLine(" 6. Listar medicamentos");

            do
            {
                Console.WriteLine("------");
                Console.Write("Opção escolhida: ");
                opc = Int32.Parse(Console.ReadLine());

                Medicamentos lista = new Medicamentos();
                
                Lote p1l1 = new Lote(1, 100, new DateTime(2002, 3, 8));
                Lote p1l2 = new Lote(2, 20, DateTime.Now);
                Lote m1l1 = new Lote(1, 50, DateTime.Now);
                Medicamento p1 = new Medicamento(1, "ParaCeTaMal", "IFSP-ADS", new Queue<Lote>());
                Medicamento m1 = new Medicamento(4, "Monoxidil", "IFSP-ADS", new Queue<Lote>());

                lista.adicionar(p1);
                lista.adicionar(m1);

                switch (opc)
                {
                    case 0: break;
                    case 1:
                        {
                            Medicamento d2 = new Medicamento(66, "Dipirona", "IFSP-CTA", new Queue<Lote>());
                            Console.WriteLine(lista.adicionar(d2) ? "Adicionou" : "Não adicionou");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine(lista.pesquisar(p1).ToString());
                            break;
                        }
                    case 3:
                        {
                            if (lista.pesquisar(p1) != null)
                            {
                                Console.WriteLine(p1.ToString());
                                foreach (Lote l in p1.lotes)
                                {
                                    Console.WriteLine("Lote: " + l.ToString());
                                }
                            }
                            break;
                        }
                    case 4:
                        {
                            p1.comprar(new Lote(100, 100, DateTime.Now));
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine(p1.vender(70) ? "Venda efetuada" : "Venda cancelada");
                            Console.WriteLine(p1.vender(100) ? "Venda efetuada" : "Venda cancelada");
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine(p1.ToString());
                            Console.WriteLine(m1.ToString());
                            break;
                        }
                }
            } while (opc != 0);
        }
    }
}
