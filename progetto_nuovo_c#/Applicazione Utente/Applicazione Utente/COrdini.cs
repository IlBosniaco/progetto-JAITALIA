using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicazione_Utente
{
    [Serializable]
    public class COrdini
    {
        List<COrdine> lista;
        string ordinazione;
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
            File.AppendAllText(Directory.GetCurrentDirectory() + @"\..\ordini.csv", ToCsv(n,c,cl));
        }

        public string ToCsv(string n, string c, string cl)
        {
            string tmp = "";
            for(int i=0;i<lista.Count;i++)
            {                
                tmp += lista.ElementAt(i).getNome() + ";";                
            }
            tmp += n + ";" + c + ";" + cl;
            setOrdinazione(tmp);
            tmp += "\n";
            return tmp;
        }
        public void setOrdinazione(string t)
        {
            ordinazione = t;
        }
        public string getOrdinazione()
        {
            return ordinazione;
        }   
    }
}
