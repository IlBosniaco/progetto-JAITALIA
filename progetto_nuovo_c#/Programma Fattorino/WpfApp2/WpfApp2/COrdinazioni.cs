using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class COrdinazioni
    {
        private List<string> lista;
        private string nomeFile;
        public int numEl;

        public COrdinazioni()
        {
            lista = new List<string>();
        }

        public void rimuoviOrdine(int pos)
        {
            lista.RemoveAt(pos);
            numEl--;
        }

        public List<string> GetOrdinazioni()
        {
            return lista;
        }
        public string GetElemento(int pos)
        {
            return lista.ElementAt(pos);
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
                ret += lista.ElementAt(i)+ "\n";
            }
            return ret;
        }
        public void Salva()
        {
            File.WriteAllText(nomeFile, GetAllCsv());
        }
        
        public void CaricaFile()
        {
            lista.Clear(); //svuota lista
            string tutto = File.ReadAllText(nomeFile);
            string[] linee = tutto.Split('\n');
            for (int i = 0; i < linee.Length; i++)
            {
                lista.Add(linee[i]);
            }
            numEl = linee.Length;
        }
    }

}
