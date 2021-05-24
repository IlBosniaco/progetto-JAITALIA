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

        }

        private void btnOrdina_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnPa_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnPi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCr_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnGo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnPa1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnFo_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
