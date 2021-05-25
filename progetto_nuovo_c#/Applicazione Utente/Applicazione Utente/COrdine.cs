using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicazione_Utente
{
    public class COrdine
    {
        public string prodotto;
        public double prezzo;

        public COrdine()
        {
            prodotto = "";
            prezzo = 0.00;
        }

        public COrdine(string l, double p)
        {
            prodotto=l;
            prezzo = p;
        }

        public double getPrezzo()
        {
            return prezzo;
        }

        public string getNome()
        {
            return prodotto;
        }
    }
}
