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
    public partial class Regjistrimi_i_produkteve : Form
    {
        public Regjistrimi_i_produkteve()
        {
            InitializeComponent();
        }


        private void btnRegjistro_Click(object sender, EventArgs e)
        {
            Menyja menu;

            if (txtboxEmriProduktit.Text != "" && comboMadhesia.Text != "" && txtboxCmimi.Text != "" && txtboxPerberes.Text != "")
            {
                string[] perberesit = txtboxPerberes.Text.Split(',');
                List<string> listPerberesit = perberesit.ToList();
                Produkti produkti = new Produkti(txtboxEmriProduktit.Text, comboMadhesia.Text,decimal.Parse(txtboxCmimi.Text), listPerberesit);
                menu = new Menyja(produkti);
                produkti.Id++;
            }
            else if(txtboxEmriProduktit.Text != "" && comboMadhesia.Text != "" && txtboxCmimi.Text != "")
            {
                Produkti produkti = new Produkti(txtboxEmriProduktit.Text, comboMadhesia.Text, decimal.Parse(txtboxCmimi.Text));
                menu = new Menyja(produkti);
                produkti.Id++;
            }
            else
            {
                Produkti produkti = new Produkti(txtboxEmriProduktit.Text, decimal.Parse(txtboxCmimi.Text));
                menu = new Menyja(produkti);
                produkti.Id++;
            }

            
            Clear();
        }

        void Clear()
        {
            txtboxEmriProduktit.Clear();
            txtboxCmimi.Clear();
            txtboxPerberes.Clear();
            comboMadhesia.Text = "";
        }

        private void txtboxEmriProduktit_TextChanged(object sender, EventArgs e)
        {
            if (txtboxEmriProduktit.Text != "")
            {
                btnRegjistro.Enabled = true;
                txtboxCmimi.Enabled = true;
                comboMadhesia.Enabled = true;
                txtboxPerberes.Enabled = true;
            }
            else
            {
                comboMadhesia.Enabled = false;
                txtboxPerberes.Enabled = false;
                btnRegjistro.Enabled = false;
                txtboxCmimi.Enabled = false;
            }
        }
    }
}
