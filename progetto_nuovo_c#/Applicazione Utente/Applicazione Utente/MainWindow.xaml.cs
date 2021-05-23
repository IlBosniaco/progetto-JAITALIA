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

namespace Applicazione_Utente
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        COrdinazioni c = new COrdinazioni();
        
        public MainWindow()
        {
            InitializeComponent();
            c.setNomeFile("dati.csv");
            c.Carica();
        }

        public MainWindow(COrdinazioni t)
        {
            InitializeComponent();
            c = t;
        }

        private void btnAccedi_Click(object sender, RoutedEventArgs e)
        {
            if (c.controllo(txtMail.ToString(), txtPssw.ToString()))
            {
                Ordinanzione tmp = new Ordinanzione(c);
            }
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
