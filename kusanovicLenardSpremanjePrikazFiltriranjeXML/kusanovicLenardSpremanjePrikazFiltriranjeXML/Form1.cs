using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kusanovicLenardSpremanjePrikazFiltriranjeXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            Unos_podataka unos_Podataka = new Unos_podataka();
            this.Hide();
            unos_Podataka.ShowDialog();
            this.Close();
        }

        private void btnPrikaz_Click(object sender, EventArgs e)
        {
            Pregled_podataka pregled_Podataka = new Pregled_podataka();
            this.Hide();
            pregled_Podataka.ShowDialog();
            this.Close();
        }
    }
}
