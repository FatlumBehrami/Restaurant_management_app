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
            comboLloji.Enabled = true;
        }

        private void comboLloji_TextChanged(object sender, EventArgs e)
        {
            comboProdukti.Enabled = true;
            if (comboLloji.Text=="Pije")
            {
                foreach (var item in Menyja.Pijet)
                {
                    comboProdukti.Items.Add(item.Emri_i_pijes);
                }
            }
            else
            {
                foreach (var item in Menyja.Ushqimet)
                {
                    comboProdukti.Items.Add(item.Emri_i_ushqimit);
                }
            }
        }

        private void comboProdukti_TextChanged(object sender, EventArgs e)
        {
            txbSasia.Enabled = true;
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

        
        void ShtoProdukt()
        {
            Produkti_i_porositur produkti = new Produkti_i_porositur();
            produkti.produkti_i_porositur = comboProdukti.Text;
            produkti.Sasia_e_porosise = int.Parse(txbSasia.Text);
            Porosia.produktet.Add(produkti);

            txbSasia.Clear();
            comboLloji.Text = "";
            comboProdukti.Text = "";

        }
        void PerfundoPorosi()
        {
            Porosia porosia = new Porosia();
            porosia.Nr_i_tavolines = int.Parse(comboID.Text);
            List<Produkti_i_porositur> lista = Porosia.produktet;
            ListaEPorosive.ShtoPorosi(porosia);

            comboID.Text = "";
            txbSasia.Clear();
            comboLloji.Text = "";
            comboProdukti.Text = "";
        }
    }
}
