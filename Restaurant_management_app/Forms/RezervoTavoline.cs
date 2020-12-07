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
    }
}
