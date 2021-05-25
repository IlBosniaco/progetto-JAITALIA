using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicazione_Utente
{
    public class Utente
    {
        string nome;
        string cognome;
        string classe;
        string mail;
        string password;

        public Utente()
        {           
            nome = "";
            cognome = "";
            classe = "";
            mail = "";
            password = "";
        }

        public Utente(string n, string c,string cl, string m, string p)
        {
            nome = n;
            cognome = c;
            classe = cl;
            mail = m;
            password = p;
        }


        public string ToCsv()
        {
            string tmp = "";
            tmp += nome + ";" + cognome + ";" + classe + ";" + mail + ";" + password;         
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

        public string getClasse()
        {
            return classe;
        }
    }
}
