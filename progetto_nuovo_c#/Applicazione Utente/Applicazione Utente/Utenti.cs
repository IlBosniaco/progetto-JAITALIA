using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicazione_Utente
{
    public class Utenti
    {
        List<Utente> lista;
        string nomeFile;
        public Utenti()
        {
            lista = new List<Utente>();
            nomeFile = "";
        }

        public void AggiungiUtente(Utente l)
        {
            lista.Add(l);
        }

        public int GetNumEl()
        {
            return lista.Count;
        }

        public void setNomeFile(string nome)
        {
            nomeFile = nome;
        }

        public string GetAllCsv()
        {
            string ret = "";
            for (int i = 0; i < this.GetNumEl(); i++)
            {
                if (i != this.GetNumEl() - 1)
                    ret += lista.ElementAt(i).ToCsv() + "\n";
                else
                    ret += lista.ElementAt(i).ToCsv();
            }
            return ret;
        }
        public void Salva()
        {
            File.WriteAllText(nomeFile, GetAllCsv());
        }

        public Utente getElemento(int i)
        {
            return lista.ElementAt(i);
        }

        public List<Utente> getLista()
        {
            return lista;
        }

        public void Carica()
        {

            Utente pTemp;
            string linea;
            string tutto = File.ReadAllText(nomeFile);

            string[] linee = tutto.Split('\n');
            if (linee[0] != "")
            {
                lista.Clear(); //svuota lista
                for (int i = 0; i < linee.Length; i++)
                {
                    linea = linee[i];
                    string[] campi = linea.Split(';');
                    pTemp = new Utente(campi[0], campi[1], campi[2], campi[3], campi[4]);
                    lista.Add(pTemp);
                }
            }
        }
        
        public int controllo(string m, string p)
        {
            for(int i=0;i<lista.Count;i++)
            {
                string mail = lista.ElementAt(i).getMail().ToString();
                string passw = lista.ElementAt(i).getPassword().ToString();
                if (mail == m && passw == p)
                    return i;
            }
            return -1;
        }

        public bool controlloR(string m)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista.ElementAt(i).getMail() == m)
                    return false;
            }
            return true;
        }
    }
}
