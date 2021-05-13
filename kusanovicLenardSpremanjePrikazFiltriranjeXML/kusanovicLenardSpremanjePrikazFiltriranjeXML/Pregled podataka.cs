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
    public partial class Pregled_podataka : Form
    {
        public Pregled_podataka()
        {
            InitializeComponent();
        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            Filtriranje_podataka filtriranje_Podataka = new Filtriranje_podataka();
            this.Hide();
            filtriranje_Podataka.ShowDialog();
            this.Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }
    }
}
