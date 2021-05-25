using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Applicazione_Utente
{
    /// <summary>
    /// Logica di interazione per Ordinanzione.xaml
    /// </summary>
    public partial class Ordinanzione : Window
    {
        Utenti c = new Utenti();
        COrdini ordine = new COrdini();
        string nome = "";
        string cognome = "";
        string classe = "";
        public Ordinanzione()
        {
            InitializeComponent();
        }

        public Ordinanzione(Utenti l,int i)
        {
            InitializeComponent();
            c = l;
            nome = c.getLista().ElementAt(i).getNome();
            cognome = c.getLista().ElementAt(i).getCognome();
            classe = c.getLista().ElementAt(i).getClasse();
        }

        private void btnOut_Click(object sender, RoutedEventArgs e)
        {
            MainWindow tmp = new MainWindow(c);
            this.Hide();
            tmp.Show();
        }

        private void btnOrdina_Click(object sender, RoutedEventArgs e)
        {
            ordine.Salva(nome, cognome, classe);
            MessageBox.Show("ordine completato");
            FinestraQR tmp = new FinestraQR(ordine.getOrdinazione(), nome, cognome, classe);
            this.Hide();
            tmp.Show();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            ordine.cancella(lst.SelectedIndex);
            refreshList();
        }

        private void btnPa_Click(object sender, RoutedEventArgs e)
        {
            ordine.aggiungi(new COrdine(btnPa.Content.ToString(), 2.5));
            refreshList();
        }

        private void btnPi_Click(object sender, RoutedEventArgs e)
        {
            ordine.aggiungi(new COrdine(btnPi.Content.ToString(), 2));
            refreshList();
        }

        private void btnCr_Click(object sender, RoutedEventArgs e)
        {
            ordine.aggiungi(new COrdine(btnCr.Content.ToString(), 0.70));
            refreshList();
        }

        private void btnGo_Click(object sender, RoutedEventArgs e)
        {
            ordine.aggiungi(new COrdine(btnGo.Content.ToString(), 0.10));
            refreshList();
        }

        private void btnPa1_Click(object sender, RoutedEventArgs e)
        {
            ordine.aggiungi(new COrdine(btnPa1.Content.ToString(), 0.80));
            refreshList();
        }

        private void btnFo_Click(object sender, RoutedEventArgs e)
        {
            ordine.aggiungi(new COrdine(btnFo.Content.ToString(), 1));
            refreshList();
        }

        public void refreshList()
        {
            lst.Items.Clear();
            for(int i=0;i<ordine.getLista().Count;i++)
            {
                if(ordine.getLista().ElementAt(i).getNome().Length<9)
                    lst.Items.Add(ordine.getLista().ElementAt(i).getNome() + "\t\t\t" + string.Format("{0:0.00}", ordine.getLista().ElementAt(i).getPrezzo()) +" €");
                else
                    lst.Items.Add(ordine.getLista().ElementAt(i).getNome() + "\t\t" + string.Format("{0:0.00}", ordine.getLista().ElementAt(i).getPrezzo()) + " €");

            }
            txtPrezzo.Text = "Totale: " + string.Format("{0:0.00}", ordine.getPrezzoTot()) + " €";
        }
    }
}
