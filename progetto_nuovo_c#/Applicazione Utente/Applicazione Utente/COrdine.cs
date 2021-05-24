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
        double prezzo;

        public COrdine()
        {
            lista = new List<string>();
            prezzo = 0;
        }

        public COrdine(List<string> l, double p)
        {
            lista = l;
            prezzo = p;
        }

        public List<string> getLista()
        {
            return lista;
        }

        public void aggiungi(string n, double p)
        {
            lista.Add(n);
            prezzo += p;
        }

        public void cancella(int i)
        {
            lista.RemoveAt(i);
            
        }

        public double getPrezzo()
        {
            return prezzo;
        }

        public void Salva()
        {
            File.AppendAllText(@"C:\Users\Matteo\Desktop\Applicazione Utente\ordini.csv", ToCsv());
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
