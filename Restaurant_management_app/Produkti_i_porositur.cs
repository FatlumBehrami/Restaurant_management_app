using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_management_app
{
    class Produkti_i_porositur
    {
        public string ProduktiIPorositur { get; set; }
        private int sasia_e_porosise;
        public int Sasia_e_porosise
        {
            get { return sasia_e_porosise; }
            set
            {
                if (value < 1)
                {
                    MessageBox.Show("Vlere e pamjaftueshme!");
                }
                else
                {
                    sasia_e_porosise = value;
                }
            }
        }
        public decimal Cmimi { get; set; }
        public Produkti_i_porositur() { }
        public Produkti_i_porositur(string produkti, int sasia, decimal cmimi)
        {
            ProduktiIPorositur = produkti;
            Sasia_e_porosise = sasia;
            Cmimi = cmimi;
        }
    }
}
