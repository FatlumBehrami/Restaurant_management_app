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
            foreach (var item in ListaETavolinave._lista)
            {
                comboID.Items.Add(item);
            }
            if (comboID.Text != "" && comboLloji.Text != "" && txbSasia.Text != "")
            {

            }

        }

        

       
    }
}
