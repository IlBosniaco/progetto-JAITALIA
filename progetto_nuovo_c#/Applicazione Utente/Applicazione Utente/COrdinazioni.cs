using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicazione_Utente
{
    public class COrdinazioni
    {
        List<COrdine> lista;
        string nomeFile;
        public COrdinazioni()
        {
            lista = new List<COrdine>();
            nomeFile = "";
        }

        public void AggiungiUtente(COrdine l)
        {
            lista.Add(l);
        }

        public void AggiungiOrdine(List<int> l, int i)
        {
            lista.ElementAt(i).setLista(l);
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

        public COrdine getElemento(int i)
        {
            return lista.ElementAt(i);
        }

        public List<COrdine> getLista()
        {
            return lista;
        }

        public void Carica()
        {

            COrdine pTemp;
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
                    pTemp = new COrdine(new List<int>(), campi[0], campi[1], campi[2], campi[3]);
                    lista.Add(pTemp);
                }
            }
        }
        
        public bool controllo(string m, string p)
        {
            for(int i=0;i<lista.Count;i++)
            {
                if (lista.ElementAt(i).getMail() == m && lista.ElementAt(i).getPassword() == p)
                    return true;
            }
            return false;
        }

        public bool controlloR(string m)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista.ElementAt(i).getMail() == m)
                    return true;
            }
            return false;
        }
    }
}
