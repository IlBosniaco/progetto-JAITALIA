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
    /// Logica di interazione per FinestraControlloQR.xaml
    /// </summary>
    public partial class FinestraControlloQR : Window
    {
        public FinestraControlloQR()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //mette nella combobox i nomi della camera attive sul pc quando avvio la finestra
            camSelect.ItemsSource = webCam.CameraNames;
        }

        private void QrWebCamControl_QrDecoded(object sender, string e)
        {
            //mette la scritta presente nel qr nella textbox  sottostante
            dtext.Text = e;
        }

        private void camSelect_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //quando seleziono una camera dalla combo prende la posizione della camera che scelgo (es ho una camera prende l'indice 0)
            webCam.CameraIndex = camSelect.SelectedIndex;
        }
    }   
}
