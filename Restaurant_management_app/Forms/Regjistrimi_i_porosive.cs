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

            foreach (Sherbyesi item in ListaESherbysve.ListaSherbysve)
            {
                cmbSherbyesi.Items.Add(item.Emri);
            }
        }

        private void comboID_TextChanged(object sender, EventArgs e)
        {
            comboProdukti.Enabled = true;
            txbSasia.Enabled = true;

                foreach (var item in Menyja.Ushqimet)
                {
                    comboProdukti.Items.Add(item.EmriUshqimit);
                }
        }

        private void txbSasia_TextChanged(object sender, EventArgs e)
        {
            btnShtoProduktin.Enabled = true;
        }

        private void btnShtoProduktin_Click(object sender, EventArgs e)
        {
            ShtoProdukt();
            txbCmimiTotal.Text = porosia.KalkuloFakturen().ToString();
        }

        private void btnPerfundoPorosin_Click(object sender, EventArgs e)
        {
            PerfundoPorosi();
        }

        Porosia porosia = new Porosia();

        void ShtoProdukt()
        {
            foreach (Produkti item in Menyja.Ushqimet)
            {
                if (comboProdukti.Text == item.EmriUshqimit)
                {
                    ProduktiItem produkti = new ProduktiItem(item, int.Parse(txbSasia.Text));
                    item.NumriShitjeve += produkti.SasiaEPorosise;
                    porosia.ShtoProdukt(produkti);
                }
            }

            txbSasia.Clear();
            comboProdukti.Text = "";
        }
        void PerfundoPorosi()
        {
            foreach (Sherbyesi item in ListaESherbysve.ListaSherbysve)
            {
                if (cmbSherbyesi.Text == item.Emri)
                {
                    porosia.Sherbyesi = item;
                    item.PerfundoShitjen();
                }
            }

            
            porosia.NrITavolines = int.Parse(comboID.Text);
            porosia.PorosiID++;
            ListaEPorosive.ShtoPorosi(porosia);

            Clear();
            
        }
        void Clear()
        {
            cmbSherbyesi.Text = "";
            comboID.Text = "";
            txbSasia.Clear();
            comboProdukti.Text = "";
        }
    }
}
