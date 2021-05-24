using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicazione_Utente
{
    public class COrdine
    {
        List<string> lista;

        public COrdine()
        {
            lista = new List<string>();
        }

        public COrdine(List<string> l)
        {
            lista = l;
        }

        public List<string> getLista()
        {
            return lista;
        }

        public void aggiungi(string n)
        {
            lista.Add(n);
        }

        public void cancella(int i)
        {
            lista.RemoveAt(i);
        }

        public void Salva()
        {
            File.AppendAllText("path", ToCsv());
        }

        public string ToCsv()
        {
            string tmp = "";
            for(int i=0;i<lista.Count;i++)
            {
                if(i != lista.Count-1)
                    tmp += lista.ElementAt(i) + ";";
                else
                    tmp += lista.ElementAt(i) + "\n";
            }
            return tmp;
        }
    }
}
