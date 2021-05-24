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
        COrdine ordine = new COrdine();
        public Ordinanzione()
        {
            InitializeComponent();
        }

        public Ordinanzione(Utenti l)
        {
            InitializeComponent();
            c = l;            
        }

        private void btnOut_Click(object sender, RoutedEventArgs e)
        {
            MainWindow tmp = new MainWindow(c);
            this.Hide();
            tmp.Show();
        }

        private void btnOrdina_Click(object sender, RoutedEventArgs e)
        {
            ordine.Salva();
            MessageBox.Show("ordine completato");
            MainWindow tmp = new MainWindow(c);
            this.Hide();
            tmp.Show();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            ordine.cancella(lst.SelectedIndex);
            lst.ItemsSource = new List<string>();
            lst.ItemsSource = ordine.getLista();
        }

        private void btnPa_Click(object sender, RoutedEventArgs e)
        {
            ordine.aggiungi(btnPa.Content.ToString(), 2.5);
            lst.ItemsSource = new List<string>();
            lst.ItemsSource = ordine.getLista();
        }

        private void btnPi_Click(object sender, RoutedEventArgs e)
        {
            ordine.aggiungi(btnPi.Content.ToString(), 2);
            lst.ItemsSource = new List<string>();
            lst.ItemsSource = ordine.getLista();
        }

        private void btnCr_Click(object sender, RoutedEventArgs e)
        {
            ordine.aggiungi(btnCr.Content.ToString(), 0.70);
            lst.ItemsSource = new List<string>();
            lst.ItemsSource = ordine.getLista();
        }

        private void btnGo_Click(object sender, RoutedEventArgs e)
        {
            ordine.aggiungi(btnGo.Content.ToString(), 0.10);
            lst.ItemsSource = new List<string>();
            lst.ItemsSource = ordine.getLista();
        }

        private void btnPa1_Click(object sender, RoutedEventArgs e)
        {
            ordine.aggiungi(btnPa1.Content.ToString(), 0.80);
            lst.ItemsSource = new List<string>();
            lst.ItemsSource = ordine.getLista();
        }

        private void btnFo_Click(object sender, RoutedEventArgs e)
        {
            ordine.aggiungi(btnFo.Content.ToString(), 1);
            lst.ItemsSource = new List<string>();
            lst.ItemsSource = ordine.getLista();
        }
    }
}
