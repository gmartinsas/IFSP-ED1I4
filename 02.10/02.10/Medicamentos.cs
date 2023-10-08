using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._10
{
    internal class Medicamentos
    {
        private List<Medicamento> listaMedicamentos;

        public Medicamentos() { listaMedicamentos = new List<Medicamento>(); }

        public List<Medicamento> ListaMedicamentos { get {  return listaMedicamentos; } }

        public bool adicionar(Medicamento medicamento)
        {
            bool adicionou = false;
            foreach (Medicamento m in listaMedicamentos)
            { 
                if (m.Equals(medicamento))
                {
                    adicionou = false;
                } else { 
                    listaMedicamentos.Add(medicamento);
                    adicionou = true;
                    break;
                }
            }
            return adicionou;
        }

        public bool deletar(Medicamento medicamento)
        {
            bool deletou = false;
            foreach (Medicamento m in listaMedicamentos)
            {
                if (m.Equals(medicamento))
                {
                    listaMedicamentos.Remove(medicamento);
                    deletou = true;
                    break;
                }
                else
                {
                    deletou = false;
                }
            }
            return deletou;
        }

        public Medicamento pesquisar(Medicamento medicamento)
        {
            Medicamento medic = new Medicamento();
            foreach (Medicamento m in listaMedicamentos)
            {
                if (m.Equals(medicamento))
                {
                    medic = m;
                    break;
                }
            }
            return medic;

        }
    }
}
