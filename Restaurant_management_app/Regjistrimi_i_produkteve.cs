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

        private void comboLloji_TextChanged(object sender, EventArgs e)
        {
            if (comboLloji.Text == "Pije")
            {
                txtboxEmriProduktit.Enabled = true;
                btnRegjistro.Enabled = true;
                txtboxCmimi.Enabled = true;
            }
            else
            {
                comboMadhesia.Enabled = true;
                txtboxEmriProduktit.Enabled = true;
                txtboxPerberes.Enabled = true;
                btnRegjistro.Enabled = true;
                txtboxCmimi.Enabled = true;
            }
        }

        private void btnRegjistro_Click(object sender, EventArgs e)
        {
            Menyja menu;

            if (comboLloji.Text == "Pije")
            {
                Pije produkti = new Pije(txtboxEmriProduktit.Text,double.Parse(txtboxCmimi.Text));
                menu = new Menyja(produkti);
            }
            else
            {
                if (!String.IsNullOrEmpty(txtboxPerberes.Text))
                {
                    string[] perberesit = txtboxPerberes.Text.Split(',');
                    List<string> listPerberesit = perberesit.ToList();
                    Ushqimi produkti = new Ushqimi(txtboxEmriProduktit.Text, comboMadhesia.Text,
                        double.Parse(txtboxCmimi.Text), listPerberesit);
                    menu = new Menyja(produkti);
                }
                else
                {
                    Ushqimi produkti = new Ushqimi(txtboxEmriProduktit.Text, comboMadhesia.Text,
                        double.Parse(txtboxCmimi.Text));
                    menu = new Menyja(produkti);
                }
            }
            Clear();
        }

        void Clear()
        {
            txtboxEmriProduktit.Clear();
            txtboxCmimi.Clear();
            txtboxPerberes.Clear();
            comboMadhesia.Text = "";
            comboLloji.Text = "";
        }
    }
}
