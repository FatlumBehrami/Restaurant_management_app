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
    public partial class RezervoTavoline : Form
    {
        public RezervoTavoline()
        {
            InitializeComponent();
        }
        

        private void RezervoTavoline_Load(object sender, EventArgs e)
        {
            
        }

        

        private void btnKerko_Click(object sender, EventArgs e)
        {
            cmbTavolinat.Items.Clear();
            foreach (Tavolina item in ListaETavolinave.Lista)
            {
                if (item.eZene == false && item.NumriKarrikave == int.Parse(txbNr.Text))
                {
                    cmbTavolinat.Items.Add(item.Id_e_tavolines);
                }
            }
        }
        Rezervimi rezervimi = new Rezervimi();
        private void btnRezervo_Click(object sender, EventArgs e)
        {

            Klienti klienti = new Klienti(txbEmri.Text, int.Parse(txbNrTelefoni.Text));
            klienti.ID++;
            rezervimi.Klienti = klienti;
            foreach (Tavolina item in ListaETavolinave.Lista)
            {
                if (item.Id_e_tavolines == int.Parse(cmbTavolinat.Text))
                {
                    rezervimi.Tavolina = item;
                }
            }
            rezervimi.Data = Convert.ToDateTime(txbData.Text);
        }
    }
}
