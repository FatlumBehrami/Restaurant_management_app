using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_management_app
{
    public partial class Restauranti : Form
    {
        public Restauranti()
        {
            InitializeComponent();
        }

        private void RegjistroProdukte_Click(object sender, EventArgs e)
        {
            Regjistrimi_i_produkteve rpr = new Regjistrimi_i_produkteve();
            rpr.Show();
        }

        private void btnRegjistroTavolinat_Click(object sender, EventArgs e)
        {
            Regjistrimi_i_tavolinave rt = new Regjistrimi_i_tavolinave();
            rt.Show();
        }

        private void btnRegjistroPorosite_Click(object sender, EventArgs e)
        {
            Regjistrimi_i_porosive rpo = new Regjistrimi_i_porosive();
            rpo.Show();
        }

        private void btnStatistikat_Click(object sender, EventArgs e)
        {
            Statistikat stat = new Statistikat();
            stat.Show();
        }

        private void btnRezervoTavoline_Click(object sender, EventArgs e)
        {
            rezer
        }
    }
}
