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
    public partial class Regjistrimi_i_porosive : Form
    {
        public Regjistrimi_i_porosive()
        {
            InitializeComponent();
        }
        private void Regjistrimi_i_porosive_Load(object sender, EventArgs e)
        {
            foreach (var item in ListaETavolinave.Lista)
            {
                comboID.Items.Add(item.Id_e_tavolines);
            }
            
        }

        private void comboID_TextChanged(object sender, EventArgs e)
        {
            comboProdukti.Enabled = true;
            txbSasia.Enabled = true;

                foreach (var item in Menyja.Ushqimet)
                {
                    comboProdukti.Items.Add(item.Emri_i_ushqimit);
                }
        }

        private void txbSasia_TextChanged(object sender, EventArgs e)
        {
            btnShtoProduktin.Enabled = true;
        }

        private void btnShtoProduktin_Click(object sender, EventArgs e)
        {
            ShtoProdukt();
        }

        private void btnPerfundoPorosin_Click(object sender, EventArgs e)
        {
            PerfundoPorosi();
        }

        Porosia porosia = new Porosia();

        void ShtoProdukt()
        {
            Produkti_i_porositur produkti = new Produkti_i_porositur(comboProdukti.Text, int.Parse(txbSasia.Text));
            porosia.ShtoProduktet(produkti);
            txbSasia.Clear();
            comboProdukti.Text = "";
        }
        void PerfundoPorosi()
        {
            porosia.Nr_i_tavolines = int.Parse(comboID.Text);  
            ListaEPorosive.ShtoPorosi(porosia);

            comboID.Text = "";
            txbSasia.Clear();
            comboProdukti.Text = "";
        }

    }
}
