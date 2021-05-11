using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace kusanovicLenardSpremanjePrikazFiltriranjeXML
{
    public partial class Unos_podataka : Form
    {
        List<Ucenik> listaUcenika = new List<Ucenik>();
        public Unos_podataka()
        {
            InitializeComponent();
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtIme.Text) || string.IsNullOrEmpty(txtPrezime.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(cmbRazred.Text))
            {
                MessageBox.Show("Krivo uneseni podatci", cmbRazred.Text);
                return;
            }

            Ucenik ucenik = new Ucenik(txtIme.Text, txtPrezime.Text, txtEmail.Text, cmbRazred.Text);
            listaUcenika.Add(ucenik);

            txtIme.Clear();
            txtPrezime.Clear();
            txtEmail.Clear();
            cmbRazred.Text = " ";
        }

        private void btnZavrsi_Click(object sender, EventArgs e)
        {
            if (!Dictionary.Exists())
        }
    }
}
