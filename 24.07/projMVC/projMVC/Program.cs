﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projMVC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coisas minhasCoisas = new Coisas(5);
            Console.WriteLine((minhasCoisas.adicionar(new Coisa(1, "Coisa 1"))) ? "Adicionou":"Não adicionou");
            Console.WriteLine((minhasCoisas.adicionar(new Coisa(2, "Coisa 2"))) ? "Adicionou" : "Não adicionou");
            Console.WriteLine((minhasCoisas.adicionar(new Coisa(3, "Coisa 3"))) ? "Adicionou" : "Não adicionou");
            Console.WriteLine((minhasCoisas.adicionar(new Coisa(4, "Coisa 4"))) ? "Adicionou" : "Não adicionou");
            Console.WriteLine((minhasCoisas.adicionar(new Coisa(5, "Coisa 5"))) ? "Adicionou" : "Não adicionou");
            Console.WriteLine((minhasCoisas.adicionar(new Coisa(6, "Coisa 6"))) ? "Adicionou" : "Não adicionou");
            Console.WriteLine(minhasCoisas.mostrar());

            Coisa coisaPesquisada = minhasCoisas.pesquisar(new Coisa(3));
            if (coisaPesquisada.Id != -1)
            {
                Console.WriteLine(coisaPesquisada.ToString());
            }
            else
            {
                Console.WriteLine("Coisa não encontrada");
            }
            Console.WriteLine(minhasCoisas.pesquisar(new Coisa(2)).ToString());

            // Código inserido para a atividade
            Console.WriteLine(minhasCoisas.remover(new Coisa(2)) ? "Removeu" : "Não removeu");
            Console.WriteLine(minhasCoisas.mostrar());
        }
    }
}
