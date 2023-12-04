using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._11
{
    internal class Frota
    {
        private List<Van> vans;
        private int limite;
        private int viagens;

        public List<Van> Vans { get { return vans; } }
        public int Viagens { get { return viagens; } }

        public Frota(int limite)
        {
            this.vans = new List<Van>();
            this.limite = limite;
        }

        public bool adicionarVan(Van v)
        {
            bool adicionou;

            if (vans.Count < this.limite)
            {
                vans.Add(v);
                adicionou = true;
            }
            else
            {
                adicionou = false;
            }
            return adicionou;
        }

        public bool removerVan(Van v)
        {
            bool removeu = false;

            foreach (Van van in vans)
            {
                if (van.Id == v.Id)
                {
                    vans.Remove(van);
                    removeu = true;
                    break;
                }
            }
            return removeu;
        }

        public void viajou()
        {
            viagens++;
        }

        public int mostraCapacidade()
        {
            int cap = 0;
            
            foreach (Van van in vans)
            {
               cap += van.Lotacao;
            }

            return cap;
        }
    }
}
