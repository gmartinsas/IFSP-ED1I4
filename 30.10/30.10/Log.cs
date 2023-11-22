using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._10
{
    internal class Log
    {
        private DateTime dtAcesso;
        private Usuario usuario;
        private bool tipoAcesso;

        public Log(Usuario u, bool ta)
        {
            dtAcesso = DateTime.Now;
            tipoAcesso = ta;
            usuario = u;
        }

        public override string ToString()
        {
            string str;

            if (tipoAcesso == true)
            {
                str = "Usuário: " + usuario.Nome + "\nHorário do Acesso: " + dtAcesso.ToString() + "\nTipo de Acesso: Autorizado";
            } else
            {
                str = "Usuário: " + usuario.Nome + "\nHorário do Acesso: " + dtAcesso.ToString() + "\nTipo de Acesso: Negado";
            }

            return str;
        }
    }
}
