using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
    /// Logica di interazione per FinestraQR.xaml
    /// </summary>
    public partial class FinestraQR : Window
    {
        Bitmap qrCodeImage;
        QRCodeGenerator qrGenerator;
        QRCodeData qrCodeData;
        string ordinazione;//da decodificare
        string nome, cognome, classe;

      

        public FinestraQR()
        {
            InitializeComponent();
        }
        public FinestraQR(string or, string n, string cg, string cl)
        {
            InitializeComponent();
            ordinazione = or;
            nome = n;
            cognome = cg;
            classe = cl;
            qrGenerator = new QRCodeGenerator();
            qrCodeData = qrGenerator.CreateQrCode(ordinazione, QRCodeGenerator.ECCLevel.Q);
            QRCode qRCode = new QRCode(qrCodeData);
            qrCodeImage = qRCode.GetGraphic(20);
            string s = nome+ " "+ cognome + ".png";
            qrCodeImage.Save(Directory.GetCurrentDirectory() + s);//salva con il nome e cognome della persona qr code nella cartella corrente
            imgQR.Source = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + s));
        }
        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow tmp = new MainWindow();
            this.Hide();
            tmp.Show();
        }
    }
}
