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
    /// Logica di interazione per Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        Utenti c = new Utenti();
        public Register()
        {
            InitializeComponent();
        }

        public Register(Utenti t)
        {
            InitializeComponent();
            c = t;
        }

        private void btnRegistrati_Click(object sender, RoutedEventArgs e)
        {
            if(txtPssw.Password!=txtConferma.Password)
            {
                MessageBox.Show("la conferma è diversa dalla password inserita");
            }
            else if (c.controlloR(txtMail.Text))
            {
                Utente o = new Utente(txtNome.Text, txtCognome.Text, txtMail.Text, txtPssw.Password);
                c.AggiungiUtente(o);
                c.Salva();
                MessageBox.Show("account creato");
                Ordinanzione tmp = new Ordinanzione(c);
                this.Hide();
                tmp.Show();
            }
            else
                MessageBox.Show("questa mail è già in uso");
        }

        private void btnAccedi_Click(object sender, RoutedEventArgs e)
        {
            MainWindow tmp = new MainWindow(c);
            this.Hide();
            tmp.Show();
        }
    }
}
