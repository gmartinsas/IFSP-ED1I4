using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Atividade01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opc;
            Console.WriteLine("Departamento Comercial -- Empresa v1.0\n-----");
            Console.WriteLine("Opções:");
            Console.WriteLine(" 0. Sair \n 1. Cadastrar vendedor \n 2. Consultar vendedor");
            Console.WriteLine(" 3. Excluir vendedor \n 4. Registrar venda \n 5. Listar vendedores");
            
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
                            Vendedores v1 = new Vendedores(10, 0);
                            Console.WriteLine(v1.addVendedor(new Vendedor(1, "A", 10)) ? "Adicionou" : "Não adicionou");
                            Console.WriteLine(v1.addVendedor(new Vendedor(2, "B", 10)) ? "Adicionou" : "Não adicionou");
                            Console.WriteLine(v1.addVendedor(new Vendedor(3, "C", 10)) ? "Adicionou" : "Não adicionou");
                            Console.WriteLine(v1.addVendedor(new Vendedor(4, "D", 10)) ? "Adicionou" : "Não adicionou");
                            Console.WriteLine(v1.addVendedor(new Vendedor(5, "E", 10)) ? "Adicionou" : "Não adicionou");
                            Console.WriteLine(v1.addVendedor(new Vendedor(6, "F", 10)) ? "Adicionou" : "Não adicionou");
                            Console.WriteLine(v1.addVendedor(new Vendedor(7, "G", 10)) ? "Adicionou" : "Não adicionou");
                            Console.WriteLine(v1.addVendedor(new Vendedor(8, "H", 10)) ? "Adicionou" : "Não adicionou");
                            Console.WriteLine(v1.addVendedor(new Vendedor(9, "I", 10)) ? "Adicionou" : "Não adicionou");
                            Console.WriteLine(v1.addVendedor(new Vendedor(10, "J", 10)) ? "Adicionou" : "Não adicionou");
                            Console.WriteLine(v1.addVendedor(new Vendedor(11, "K", 10)) ? "Adicionou" : "Não adicionou");
                            break;
                        }
                    case 2:
                        {
                            Vendedores v2 = new Vendedores(10, 0);
                            Vendedor vd1 = new Vendedor(1, "Arthur", 5);
                            Vendedor vd2 = new Vendedor(2, "Patrícia", 20);
                            v2.addVendedor(vd1);
                            Console.WriteLine(v2.searchVendedor(vd1));
                            Console.WriteLine("-----");
                            Console.WriteLine(v2.searchVendedor(vd2));
                            break;
                        }
                    case 3:
                        {
                            Vendedores v3 = new Vendedores(10, 0);
                            Vendedor vd3 = new Vendedor(3, "Júlio", 2.5);
                            Vendedor vd4 = new Vendedor(4, "Roberto", 15);
                            v3.addVendedor(vd3);
                            v3.addVendedor(vd4);
                            Venda venda1 = new Venda(3, 75);
                            vd3.registrarVenda(1, venda1);

                            Console.WriteLine(v3.delVendedor(vd3) ? "Deletou" : "Não deletou");
                            Console.WriteLine("-----");
                            Console.WriteLine(v3.listarVendedores());
                            Console.WriteLine(v3.delVendedor(vd4) ? "Deletou" : "Não deletou");
                            Console.WriteLine("-----");
                            Console.WriteLine(v3.listarVendedores());
                            break;
                        }
                    case 4:
                        {
                            Vendedor vd5 = new Vendedor(5, "Nas", 50);                            Venda venda1 = new Venda(3, 75);
                            Venda venda2 = new Venda(10, 50);
                            vd5.registrarVenda(1, venda2);
                            break;
                        }
                    case 5:
                        {
                            Vendedores v4 = new Vendedores(10, 0);
                            v4.addVendedor(new Vendedor(1, "A", 10));
                            v4.addVendedor(new Vendedor(2, "B", 10));
                            v4.addVendedor(new Vendedor(3, "C", 10));
                            v4.addVendedor(new Vendedor(4, "D", 10));
                            
                            Console.WriteLine(v4.listarVendedores());
                            break;
                        }
                }
            } while (opc != 0);
        }
    }
}
