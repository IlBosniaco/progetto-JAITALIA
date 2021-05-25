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
    /// Logica di interazione per FinestraVisualizza.xaml
    /// </summary>
    public partial class FinestraVisualizza : Window
    {
        COrdinazioni ordinazioni = new COrdinazioni();
        public FinestraVisualizza()
        {
            InitializeComponent();
        }
        public FinestraVisualizza(COrdinazioni o)
        {
            InitializeComponent();
            ordinazioni = o;
            lstview.ItemsSource = ordinazioni.GetOrdinazioni();
        }
        private void btnIndietro_Click(object sender, RoutedEventArgs e)
        {
            Main tmp = new Main(ordinazioni);
            this.Hide();
            tmp.Show();
        }

    }
}
