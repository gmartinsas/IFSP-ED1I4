using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._10
{
    internal class Ambiente
    {
        private int id;
        private string nome;
        private Queue<Log> logs;

        public Ambiente(string n)
        {
            id = DateTime.Now.Day * DateTime.Now.Second;
            nome = n;
            logs = new Queue<Log>();
        }

        public string Nome { get => nome; set => nome = value; }

        public void registrarLog(Log l)
        {
            if (logs.Count <= 100)
            {
                logs.Enqueue(l);
            }
        }

        public string listaLogs()
        {
            string str = "";
            
            foreach (var log in logs)
            {
                str += log.ToString() + "\n";
            }
            return str;
        }

        public override string ToString()
        {
            return Nome + "\n" + listaLogs();
        }
    }
}
