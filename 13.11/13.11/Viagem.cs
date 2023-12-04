using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._11
{
    internal class Viagem
    {
        private Aeroporto partida;
        private Aeroporto destino;
        private Frota viajantes;

        public Viagem(Aeroporto p, Aeroporto d, Frota f)
        {
            this.partida = p;
            this.destino = d;
            this.viajantes = f;
        }

        public void iniciarViagem()
        {
            this.partida.lotarGaragem(viajantes);
        }
        
        public override string ToString()
        {
            string n = "Viagem partindo de: ";
            n += partida.Nome + " destinada a ";
            n += destino.Nome + ".";

            return n;
        }
    }
}
