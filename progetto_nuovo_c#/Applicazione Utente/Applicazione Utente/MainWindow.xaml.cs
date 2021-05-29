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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace Applicazione_Utente
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Utenti c = new Utenti();
        
        public MainWindow()
        {
            InitializeComponent();
            c.setNomeFile(Directory.GetCurrentDirectory()+@"\..\dati.csv");
            c.Carica();
        }

        public MainWindow(Utenti t)
        {
            InitializeComponent();
            c = t;
        }

        private void btnAccedi_Click(object sender, RoutedEventArgs e)
        {
            int i = c.controllo(txtMail.Text, txtPssw.Password);
            if (i>=0)
            {
                Ordinanzione tmp = new Ordinanzione(c,i);
                this.Hide();
                tmp.Show();
            }
            else
                MessageBox.Show("credenziali sbagliate");
        }

        private void btnRegistrati_Click(object sender, RoutedEventArgs e)
        {
            Register tmp = new Register(c);
            this.Hide();
            tmp.Show();
        }
    }
}
