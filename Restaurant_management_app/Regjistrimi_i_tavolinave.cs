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
    public partial class Regjistrimi_i_tavolinave : Form
    {
        public Regjistrimi_i_tavolinave()
        {
            InitializeComponent();
        }

        private void btnShto_Click(object sender, EventArgs e)
        {
            try
            {
               int id = int.Parse(txbId.Text);
               int nrKarrikat = int.Parse(txbNrKarrikat.Text);
                Tavolina tavolina = new Tavolina(id,nrKarrikat);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            txbId.Clear();
            txbNrKarrikat.Clear();
        }
    }
}
