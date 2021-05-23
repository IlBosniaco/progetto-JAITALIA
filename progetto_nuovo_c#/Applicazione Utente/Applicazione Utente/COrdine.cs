using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicazione_Utente
{
    public class COrdine
    {
        string nome;
        string cognome;
        string mail;
        string password;
        List<int> lista;

        public COrdine()
        {
            lista = new List<int>();
            nome = "";
            cognome = "";
            mail = "";
            password = "";
        }

        public COrdine(List<int> l, string n, string c, string m, string p)
        {
            lista = l;
            nome = n;
            cognome = c;
            mail = m;
            password = p;
        }


        public string ToCsv()
        {
            string tmp = "";
            tmp += nome + ";" + cognome + ";" + mail + ";" + password + ";";
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista.Count == i)
                    tmp += lista.ElementAt(i).ToString();
                else
                    tmp += lista.ElementAt(i).ToString() + ",";
            }           
            return tmp;
        }

        public string getNome()
        {
            return nome;
        }

        public string getCognome()
        {
            return cognome;
        }
        public string getMail()
        {
            return mail;
        }
        public string getPassword()
        {
            return password;
        }
        public List<int> getLista()
        {
            return lista;
        }

        public void setLista(List<int> l)
        {
            lista = l;
        }
    }
}
