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

namespace WpfApp2
{
    /// <summary>
    /// Logica di interazione per Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        COrdinazioni ordinazioni = new COrdinazioni();
        public Main()
        {
            InitializeComponent();
            ordinazioni.setNomeFile(@"C:\Users\Matteo\Desktop\Applicazione Utente\ordini.csv");
            ordinazioni.CaricaFile();
        }
        public Main(COrdinazioni o)
        {
            InitializeComponent();
            ordinazioni = o;
        }

        private void btnVisualizza_Click(object sender, RoutedEventArgs e)
        {
           FinestraVisualizza  tmp = new FinestraVisualizza(ordinazioni);
            this.Hide();
            tmp.Show();
        }

        private void btnScanerizza_Click(object sender, RoutedEventArgs e)
        {
            FinestraControlloQR tmp = new FinestraControlloQR(ordinazioni);
            this.Hide();
            tmp.Show();
        }
    }
}
