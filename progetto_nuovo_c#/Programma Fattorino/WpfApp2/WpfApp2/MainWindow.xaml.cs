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

namespace WpfApp2
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string password = "123";
        public MainWindow()
        {
            InitializeComponent();
            /*OpenFileDialog open = new OpenFileDialog();
             if (open.ShowDialog() == true)
             {
                 g.setnomefile(open.FileName);
                 g.CaricaFile();
             }*/
        }
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (Password_box.Password == password)
            {
                MessageBox.Show("PASSWORD CORRETTA");

                FinestraControlloQR tmp = new FinestraControlloQR();
                this.Hide();
                tmp.Show();

            }
            else
            {
                MessageBox.Show("PASSWORD ERRATA");
            }
        }
    }
}
