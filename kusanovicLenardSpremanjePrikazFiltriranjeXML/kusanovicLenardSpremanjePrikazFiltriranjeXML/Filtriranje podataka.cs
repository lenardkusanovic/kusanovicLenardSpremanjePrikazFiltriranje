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
    public partial class Filtriranje_podataka : Form
    {
        public Filtriranje_podataka()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Pregled_podataka pregled_Podataka = new Pregled_podataka();
            this.Hide();
            pregled_Podataka.ShowDialog();
            this.Close();
        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            Pregled_podataka pregled_Podataka = new Pregled_podataka();
            this.Hide();
            pregled_Podataka.ShowDialog();
            this.Close();
        }
    }
}
