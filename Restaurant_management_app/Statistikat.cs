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
    public partial class Statistikat : Form
    {
        public Statistikat()
        {
            InitializeComponent();
        }

        private void btnShfaq_Click(object sender, EventArgs e)
        {
            Porosia porosia = new Porosia();
            MessageBox.Show(porosia.KalkuloFakturen().ToString());
            
            //foreach (Porosia item in ListaEPorosive.ListaPorosive)
            //{
            //    MessageBox.Show(item.PorosiID);
            //}
            
                //foreach (Produkti_i_porositur element in Porosia.Produktet)
                //{
                //txbStatistikat.Text += "STATISTIKAT" + Environment.NewLine + "Produkti me i shitur: " + element.ProduktiIPorositur + " Sasia :" + element.Sasia_e_porosise;}      
            
        }
    }
}
