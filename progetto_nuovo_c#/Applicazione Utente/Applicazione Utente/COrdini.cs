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

        public void Salva(string n, string c, string cl)
        {
            File.AppendAllText(@"C:\Users\Matteo\Desktop\Applicazione Utente\ordini.csv", ToCsv(n,c,cl));
        }

        public string ToCsv(string n, string c, string cl)
        {
            string tmp = "";
            for(int i=0;i<lista.Count;i++)
            {                
                tmp += lista.ElementAt(i).getNome() + ";";                
            }
            tmp += n + ";" + c + ";" + cl+"\n";
            return tmp;
        }
    }
}
