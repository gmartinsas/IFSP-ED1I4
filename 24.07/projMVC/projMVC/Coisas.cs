﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projMVC
{
    internal class Coisas
    {
        private Coisa[] asCoisas;
        private int max;
        private int qtde;

        public int Max { 
            get => max; 
        }
        public int Qtde {
            get => qtde; 
        }
        internal Coisa[] AsCoisas {
            get => asCoisas; 
        }

        public Coisas(int max)
        {
            this.max = max;
            this.qtde = 0;
            this.asCoisas = new Coisa[this.max];
            for(int i= 0; i < this.max; i++)
            {
                this.asCoisas[i] = new Coisa(-1, "...");
            }
        }

        public string mostrar()
        {
            string s = "";
            foreach(Coisa c in this.asCoisas)
            {
                if (c.Id != -1)
                {
                    s += c.ToString();
                }
            }
            return s;
        }

        public bool adicionar(Coisa c)
        {
            bool podeAdicionar = (this.qtde < this.max);
            if (podeAdicionar)
            {
                this.asCoisas[this.qtde++] = c;
            }
            return podeAdicionar;
        }

        public Coisa pesquisar(Coisa c)
        {
            Coisa coisaAchada = new Coisa(-1, "...");
            int i = 0;
            while (i < this.max && this.asCoisas[i].Id != c.Id)
            {
                i++;
            }
            if (i<this.max)
            {
                coisaAchada = this.asCoisas[i];
            }
            return coisaAchada;
        }

        public bool remover(Coisa c)
        {
            _ = new Coisa(-1, "...");
            Coisa coisaPesquisada = pesquisar(c);
            for (int i = 0; i < this.asCoisas.Length; i++)
            {
                if (coisaPesquisada == this.asCoisas[i])
                {
                    this.asCoisas[i].Id = -1;
                    this.asCoisas[i].Descricao = "...";
                }
            }
            return true;
        }
    }


}
