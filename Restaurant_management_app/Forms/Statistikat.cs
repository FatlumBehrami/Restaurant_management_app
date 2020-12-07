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
        
        private void btnShfaqProduktin_Click(object sender, EventArgs e)
        {
            Produkti produktiMeIShitur = new Produkti();
            if (Menyja.Ushqimet.Count > 1)
            {
                for (int i = 0; i < Menyja.Ushqimet.Count; i++)
                {
                    for (int j = 1; j < Menyja.Ushqimet.Count; j++)
                    {
                        if (Menyja.Ushqimet[j].NumriShitjeve > Menyja.Ushqimet[i].NumriShitjeve)
                        {
                            produktiMeIShitur = Menyja.Ushqimet[j];
                        }
                    }
                }
                txbStatistikat.Text += "Produkti me i shitur eshte " + produktiMeIShitur.EmriUshqimit + " me " + produktiMeIShitur.NumriShitjeve + " produkte te shitura.";
            }
            else if (Menyja.Ushqimet.Count == 1) {
                produktiMeIShitur = Menyja.Ushqimet[0];
                txbStatistikat.Text += "Produkti me i shitur eshte " + produktiMeIShitur.EmriUshqimit + " me    " + produktiMeIShitur.NumriShitjeve + "produkte te shitura.";
            }
                
            else txbStatistikat.Text += "Nuk ka produkte te shitura.";
            
        }
    }
}
