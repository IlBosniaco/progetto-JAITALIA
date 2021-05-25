using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicazione_Utente
{
    public class COrdini
    {
        List<COrdine> lista;

        public COrdini()
        {
            lista = new List<COrdine>();
        }

        public COrdini(List<COrdine> l)
        {
            lista = l;
        }

        public List<COrdine> getLista()
        {
            return lista;
        }

        public void aggiungi(COrdine n)
        {
            lista.Add(n);
        }

        public void cancella(int i)
        {
            lista.RemoveAt(i);
            
        }

        public double getPrezzoTot()
        {
            double tmp = 0;
            for(int i=0; i<lista.Count; i++)
            {
                tmp+=lista.ElementAt(i).getPrezzo();
            }
            return tmp;
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
                    tmp += lista.ElementAt(i).getNome() + ";";
                else
                    tmp += lista.ElementAt(i).getNome() + "\n";
            }
            return tmp;
        }
    }
}
