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
            cmbAnno.Items.Add("1");
            cmbAnno.Items.Add("2");
            cmbAnno.Items.Add("3");
            cmbAnno.Items.Add("4");
            cmbAnno.Items.Add("5");
            cmbSezione.Items.Add("A");
            cmbSezione.Items.Add("B");
            cmbSezione.Items.Add("C");
            cmbSezione.Items.Add("D");
            cmbIndirizzo.Items.Add("info");
            cmbIndirizzo.Items.Add("mecc");
            cmbIndirizzo.Items.Add("scie");
            cmbIndirizzo.Items.Add("lice");
            cmbIndirizzo.Items.Add("ling");
            cmbIndirizzo.Items.Add("chim");
        }

        private void btnRegistrati_Click(object sender, RoutedEventArgs e)
        {
            if (!(txtNome.Text == "" || txtCognome.Text == "" || cmbAnno.Text =="" || cmbSezione.Text=="" || cmbIndirizzo.Text == "" || txtMail.Text == "" || txtPssw.Password == "" || txtConferma.Password == ""))
            {
                if (txtPssw.Password != txtConferma.Password)
                {
                    MessageBox.Show("la conferma è diversa dalla password inserita");
                }
                else if (c.controlloR(txtMail.Text))
                {
                    Utente o = new Utente(txtNome.Text, txtCognome.Text, cmbAnno.Text + cmbSezione.Text+cmbIndirizzo.Text, txtMail.Text, txtPssw.Password);
                    c.AggiungiUtente(o);
                    c.Salva();
                    MessageBox.Show("account creato");
                    Ordinanzione tmp = new Ordinanzione(c, c.getLista().Count-1);
                    this.Hide();
                    tmp.Show();
                }
                else
                    MessageBox.Show("questa mail è già in uso");
            }
            else
                MessageBox.Show("riempi tutti i campi");
            
        }

        private void btnAccedi_Click(object sender, RoutedEventArgs e)
        {
            MainWindow tmp = new MainWindow(c);
            this.Hide();
            tmp.Show();
        }

        private void txtMail_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
